using System.Diagnostics;

namespace System.Data
{
    partial class DataRowExtensions
    {
        public static bool? GetNullableBoolean(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool? GetNullableBoolean(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool? GetNullableBoolean(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool? GetNullableBoolean(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static byte? GetNullableByte(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToByte(obj);
        }

        public static byte? GetNullableByte(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToByte(obj);
        }

        public static byte? GetNullableByte(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToByte(obj);
        }

        public static byte? GetNullableByte(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToByte(obj);
        }

        public static char? GetNullableChar(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToChar(obj);
        }

        public static char? GetNullableChar(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToChar(obj);
        }

        public static char? GetNullableChar(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToChar(obj);
        }

        public static char? GetNullableChar(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToChar(obj);
        }

        public static DateTime? GetNullableDateTime(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime? GetNullableDateTime(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime? GetNullableDateTime(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime? GetNullableDateTime(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static decimal? GetNullableDecimal(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToDecimal(obj);
        }

        public static decimal? GetNullableDecimal(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToDecimal(obj);
        }

        public static decimal? GetNullableDecimal(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToDecimal(obj);
        }

        public static decimal? GetNullableDecimal(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToDecimal(obj);
        }

        public static double? GetNullableDouble(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToDouble(obj);
        }

        public static double? GetNullableDouble(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToDouble(obj);
        }

        public static double? GetNullableDouble(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToDouble(obj);
        }

        public static double? GetNullableDouble(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToDouble(obj);
        }

        public static float? GetNullableFloat(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return (float)Convert.ToDouble(obj);
        }

        public static float? GetNullableFloat(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return (float)Convert.ToDouble(obj);
        }

        public static float? GetNullableFloat(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return (float)Convert.ToDouble(obj);
        }

        public static float? GetNullableFloat(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return (float)Convert.ToDouble(obj);
        }

        public static Guid? GetNullableGuid(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid? GetNullableGuid(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid? GetNullableGuid(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid? GetNullableGuid(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static short? GetNullableInt16(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToInt16(obj);
        }

        public static short? GetNullableInt16(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToInt16(obj);
        }

        public static short? GetNullableInt16(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToInt16(obj);
        }

        public static short? GetNullableInt16(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToInt16(obj);
        }

        public static int? GetNullableInt32(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToInt32(obj);
        }

        public static int? GetNullableInt32(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToInt32(obj);
        }

        public static int? GetNullableInt32(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToInt32(obj);
        }

        public static int? GetNullableInt32(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToInt32(obj);
        }

        public static long? GetNullableInt64(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            return Convert.ToInt64(obj);
        }

        public static long? GetNullableInt64(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            return Convert.ToInt64(obj);
        }

        public static long? GetNullableInt64(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            return Convert.ToInt64(obj);
        }

        public static long? GetNullableInt64(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            return Convert.ToInt64(obj);
        }

        public static string? GetNullableString(this DataRow dataRow, int columnIndex)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnIndex))
            {
                return null;
            }
            object obj = dataRow[columnIndex];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj);
        }

        public static string? GetNullableString(this DataRow dataRow, string columnName)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(columnName))
            {
                return null;
            }
            object obj = dataRow[columnName];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj);
        }

        public static string? GetNullableString(this DataRow dataRow, DataColumn column)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column))
            {
                return null;
            }
            object obj = dataRow[column];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj);
        }

        public static string? GetNullableString(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataRow);
#else
            Throw.IfNull(dataRow);
#endif
            if (dataRow.IsNull(column, version))
            {
                return null;
            }
            object obj = dataRow[column, version];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj);
        }

    }
}
