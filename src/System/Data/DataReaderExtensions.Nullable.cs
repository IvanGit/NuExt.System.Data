using System.Data.Common;

namespace System.Data
{
    partial class DataReaderExtensions
    {
        public static bool? GetNullableBoolean(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetBoolean(ordinal);
        }

        public static bool? GetNullableBoolean(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetBoolean(ordinal);
        }

        public static byte? GetNullableByte(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetByte(ordinal);
        }

        public static byte? GetNullableByte(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetByte(ordinal);
        }

        public static char? GetNullableChar(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetChar(ordinal);
        }

        public static char? GetNullableChar(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetChar(ordinal);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDateTime(ordinal);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDateTime(ordinal);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDecimal(ordinal);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDecimal(ordinal);
        }

        public static double? GetNullableDouble(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDouble(ordinal);
        }

        public static double? GetNullableDouble(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetDouble(ordinal);
        }

        public static float? GetNullableFloat(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetFloat(ordinal);
        }

        public static float? GetNullableFloat(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetFloat(ordinal);
        }

        public static Guid? GetNullableGuid(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetGuid(ordinal);
        }

        public static Guid? GetNullableGuid(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetGuid(ordinal);
        }

        public static short? GetNullableInt16(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt16(ordinal);
        }

        public static short? GetNullableInt16(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt16(ordinal);
        }

        public static int? GetNullableInt32(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt32(ordinal);
        }

        public static int? GetNullableInt32(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt32(ordinal);
        }

        public static long? GetNullableInt64(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt64(ordinal);
        }

        public static long? GetNullableInt64(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetInt64(ordinal);
        }

        public static string? GetNullableString(this DbDataReader reader, int ordinal)
        {
            ArgumentNullException.ThrowIfNull(reader);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetString(ordinal);
        }

        public static string? GetNullableString(this DbDataReader reader, string name)
        {
            ArgumentNullException.ThrowIfNull(reader);

            int ordinal = reader.GetOrdinal(name);
            if (reader.IsDBNull(ordinal))
            {
                return null;
            }
            return reader.GetString(ordinal);
        }
    }
}
