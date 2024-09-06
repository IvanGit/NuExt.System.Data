using System.Diagnostics;

namespace System.Data
{
    /// <summary>
    /// Represents a database converter responsible for managing and applying updates to the database schema.
    /// </summary>
    /// <typeparam name="TDbConnection">The type of the database connection.</typeparam>
    public interface IDbConverter<in TDbConnection> where TDbConnection : IDbConnection
    {
        /// <summary>
        /// Gets the version of the database schema that this converter is designed to update to.
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// Retrieves the current version of the database schema from the specified connection.
        /// </summary>
        /// <param name="connection">The database connection to use for retrieving the version.</param>
        /// <returns>The current version of the database schema.</returns>
        Version GetDbVersion(TDbConnection connection);

        /// <summary>
        /// Determines whether the database requires an update to match the version specified by this converter.
        /// </summary>
        /// <param name="connection">The database connection to check.</param>
        /// <returns><c>true</c> if the database requires an update; otherwise, <c>false</c>.</returns>
        bool RequiresUpdate(TDbConnection connection);

        /// <summary>
        /// Applies the necessary updates to the database to bring it in line with the version specified by this converter.
        /// </summary>
        /// <param name="connection">The database connection to update.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        bool Update(TDbConnection connection);
    }

    public static class DbConverterExtensions
    {
        private static void CheckDbVersion<TDbConnection>(TDbConnection connection, Func<TDbConnection, Version> getDbVersion, Version dbVersion) where TDbConnection : IDbConnection
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
            var version = getDbVersion(connection);
            if (version > dbVersion)
            {
                throw new DataException("File created in a later version of the program. Install the new version to open this file.");
            }
        }

        public static void Initialize<TDbConnection>(this IDbConverter<TDbConnection>[] converters, IDbContext context) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(converters);
            ArgumentNullException.ThrowIfNull(context);
#else
            Throw.IfNull(converters);
            Throw.IfNull(context);
#endif
            converters.Initialize((TDbConnection)context.Connection);
        }

        public static void Initialize<TDbConnection>(this IDbConverter<TDbConnection>[] converters, TDbConnection connection) where TDbConnection : IDbConnection
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(converters);
            ArgumentNullException.ThrowIfNull(connection);
#else
            Throw.IfNull(converters);
            Throw.IfNull(connection);
#endif
            Debug.Assert(converters.Length > 0);
            Debug.Assert(converters.IsOrderedByAscending());
            Debug.Assert(connection is { State: ConnectionState.Open }, $"{nameof(connection)} is not opened.");

            Throw.InvalidOperationExceptionIf(!converters.IsOrderedByAscending(), $"{nameof(converters)} are not ordered by version in ascending order.");
            Throw.InvalidOperationExceptionIf(connection is not { State: ConnectionState.Open }, $"{nameof(connection)} is not opened.");
            try
            {

#if NETFRAMEWORK || NETSTANDARD2_0
                var dbVersion = converters[converters.Length - 1].Version;
#else
                var dbVersion = converters[^1].Version;
#endif
                if (converters.RequiresUpdate(connection))
                {
                    bool result = converters.Update(connection, dbVersion);
                    Debug.Assert(result);
                }
                CheckDbVersion(connection, converters[0].GetDbVersion, dbVersion);
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
                throw;
            }
        }

        private static bool IsOrderedByAscending<TDbConnection>(this IDbConverter<TDbConnection>[] converters)
            where TDbConnection : IDbConnection
        {
            for (int i = 1; i < converters.Length; i++)
            {
                if (converters[i - 1].Version > converters[i].Version)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool RequiresUpdate<TDbConnection>(this IDbConverter<TDbConnection>[] converters, TDbConnection connection) where TDbConnection : IDbConnection
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
                converters[converters.Length - 1]
#else
                converters[^1]
#endif
                .RequiresUpdate(connection))
            {
                return true;
            }
            return false;
        }

        private static bool Update<TDbConnection>(this IDbConverter<TDbConnection>[] converters, TDbConnection connection, Version dbVersion, bool forceUpdate = false) where TDbConnection : IDbConnection
        {
            Debug.Assert(converters != null);
            Debug.Assert(connection is { State: ConnectionState.Open });
            Debug.Assert(dbVersion != null);

            Version? latestVersion = null;
            foreach (var converter in converters!)
            {
                if (forceUpdate || converter.RequiresUpdate(connection))
                {
                    bool updated = converter.Update(connection);
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
