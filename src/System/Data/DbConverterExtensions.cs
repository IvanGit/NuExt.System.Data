using System.Diagnostics;

namespace System.Data
{
    public static class DbConverterExtensions
    {
        private static void CheckDbVersion<TDbConnection>(TDbConnection connection, Func<TDbConnection, CancellationToken, Version> getDbVersion, Version dbVersion, CancellationToken cancellationToken) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(connection);
            ArgumentNullException.ThrowIfNull(getDbVersion);
            ArgumentNullException.ThrowIfNull(dbVersion);
#else
            Throw.IfNull(connection);
            Throw.IfNull(getDbVersion);
            Throw.IfNull(dbVersion);
#endif
            var version = getDbVersion(connection, cancellationToken);
            if (version > dbVersion)
            {
                throw new DataException("File created in a later version of the program. Install the new version to open this file.");
            }
        }

        public static void Initialize<TDbConnection>(this IReadOnlyList<DbConverter<TDbConnection>> converters, IDbContext context, CancellationToken cancellationToken) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(converters);
            ArgumentNullException.ThrowIfNull(context);
#else
            Throw.IfNull(converters);
            Throw.IfNull(context);
#endif
            converters.Initialize((TDbConnection)context.Connection, cancellationToken);
        }

        public static void Initialize<TDbConnection>(this IReadOnlyList<DbConverter<TDbConnection>> converters, TDbConnection connection, CancellationToken cancellationToken) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(converters);
            ArgumentNullException.ThrowIfNull(connection);
#else
            Throw.IfNull(converters);
            Throw.IfNull(connection);
#endif
            Debug.Assert(converters.Count > 0);
            Debug.Assert(converters.IsOrderedByAscending());
            Debug.Assert(connection is { State: ConnectionState.Open }, $"{nameof(connection)} is not opened.");

            Throw.InvalidOperationExceptionIf(!converters.IsOrderedByAscending(), $"{nameof(converters)} are not ordered by version in ascending order.");
            Throw.InvalidOperationExceptionIf(connection is not { State: ConnectionState.Open }, $"{nameof(connection)} is not opened.");
            try
            {

#if NETFRAMEWORK || NETSTANDARD2_0
                var dbVersion = converters[converters.Count - 1].Version;
#else
                var dbVersion = converters[^1].Version;
#endif
                if (converters.RequiresUpdate(connection, cancellationToken))
                {
                    bool result = converters.Update(connection, dbVersion, cancellationToken);
                    Debug.Assert(result);
                }
#if NETFRAMEWORK || NETSTANDARD2_0
                CheckDbVersion(connection, converters[converters.Count - 1].GetDbVersion, dbVersion, cancellationToken);
#else
                CheckDbVersion(connection, converters[^1].GetDbVersion, dbVersion, cancellationToken);
#endif
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
                throw;
            }
        }

        private static bool IsOrderedByAscending<TDbConnection>(this IReadOnlyList<DbConverter<TDbConnection>> converters)
            where TDbConnection : IDbConnection
        {
            for (int i = 1; i < converters.Count; i++)
            {
                if (converters[i - 1].Version >= converters[i].Version)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool RequiresUpdate<TDbConnection>(this IReadOnlyList<DbConverter<TDbConnection>> converters, TDbConnection connection, CancellationToken cancellationToken) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(converters);
            ArgumentNullException.ThrowIfNull(connection);
#else
            Throw.IfNull(converters);
            Throw.IfNull(connection);
#endif
            Debug.Assert(connection is { State: ConnectionState.Open }, $"{nameof(connection)} is not opened.");
            if (
#if NETFRAMEWORK || NETSTANDARD2_0
                converters[converters.Count - 1]
#else
                converters[^1]
#endif
                .RequiresUpdate(connection, cancellationToken))
            {
                return true;
            }
            return false;
        }

        private static bool Update<TDbConnection>(this IReadOnlyList<DbConverter<TDbConnection>> converters, TDbConnection connection, Version dbVersion, CancellationToken cancellationToken) where TDbConnection : IDbConnection
        {
            Debug.Assert(converters != null);
            Debug.Assert(connection is { State: ConnectionState.Open });
            Debug.Assert(dbVersion != null);

            Version? latestVersion = null;
            foreach (var converter in converters!)
            {
                if (/*forceUpdate || */converter.RequiresUpdate(connection, cancellationToken))
                {
                    bool updated = converter.Update(connection, cancellationToken);
                    Debug.Assert(updated);
                    if (!updated)
                    {
                        throw new DataException($"Data base is not updated to version: {converter.Version}");
                    }
                    latestVersion = converter.Version;
                }
            }
            Debug.Assert(dbVersion == latestVersion);
            return (latestVersion == dbVersion);
        }
    }
}
