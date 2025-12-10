using System.Diagnostics;

namespace System.Data
{
    /// <summary>Provides extension methods for <see cref="T:System.Data.DataRow" />.</summary>
    public static partial class DataRowExtensions
    {
        public static bool GetBoolean(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long || obj is int);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool GetBoolean(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long || obj is int);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool GetBoolean(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long || obj is int);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static bool GetBoolean(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            if (obj is bool b)
            {
                return b;
            }
            Debug.Assert(obj is long || obj is int);
            /*int result;
            if (int.TryParse(Convert.ToString(obj), out result))
            {
                return result != 0;
            }*/
            return Convert.ToBoolean(obj);
        }

        public static byte GetByte(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToByte(obj);
        }

        public static byte GetByte(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToByte(obj);
        }

        public static byte GetByte(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToByte(obj);
        }

        public static byte GetByte(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToByte(obj);
        }

        public static char GetChar(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToChar(obj);
        }

        public static char GetChar(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToChar(obj);
        }

        public static char GetChar(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToChar(obj);
        }

        public static char GetChar(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToChar(obj);
        }

        public static DateTime GetDateTime(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime GetDateTime(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime GetDateTime(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static DateTime GetDateTime(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            if (obj is DateTime dt)
            {
                return dt;
            }
            return Convert.ToDateTime(obj);
        }

        public static decimal GetDecimal(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToDecimal(obj);
        }

        public static decimal GetDecimal(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToDecimal(obj);
        }

        public static decimal GetDecimal(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToDecimal(obj);
        }

        public static decimal GetDecimal(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToDecimal(obj);
        }

        public static double GetDouble(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToDouble(obj);
        }

        public static double GetDouble(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToDouble(obj);
        }

        public static double GetDouble(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToDouble(obj);
        }

        public static double GetDouble(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToDouble(obj);
        }

        public static float GetFloat(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return (float)Convert.ToDouble(obj);
        }

        public static float GetFloat(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return (float)Convert.ToDouble(obj);
        }

        public static float GetFloat(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return (float)Convert.ToDouble(obj);
        }

        public static float GetFloat(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return (float)Convert.ToDouble(obj);
        }

        public static Guid GetGuid(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid GetGuid(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid GetGuid(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static Guid GetGuid(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            if (obj is Guid g)
            {
                return g;
            }
            return Guid.Parse(Convert.ToString(obj)!);//TODO
        }

        public static short GetInt16(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToInt16(obj);
        }

        public static short GetInt16(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToInt16(obj);
        }

        public static short GetInt16(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToInt16(obj);
        }

        public static short GetInt16(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToInt16(obj);
        }

        public static int GetInt32(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToInt32(obj);
        }

        public static int GetInt32(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToInt32(obj);
        }

        public static int GetInt32(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToInt32(obj);
        }

        public static int GetInt32(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToInt32(obj);
        }

        public static long GetInt64(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            return Convert.ToInt64(obj);
        }

        public static long GetInt64(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            return Convert.ToInt64(obj);
        }

        public static long GetInt64(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            return Convert.ToInt64(obj);
        }

        public static long GetInt64(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            return Convert.ToInt64(obj);
        }

        public static string GetString(this DataRow dataRow, int columnIndex)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnIndex];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj)!;
        }

        public static string GetString(this DataRow dataRow, string columnName)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[columnName];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj)!;
        }

        public static string GetString(this DataRow dataRow, DataColumn column)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj)!;
        }

        public static string GetString(this DataRow dataRow, DataColumn column, DataRowVersion version)
        {
            ArgumentNullException.ThrowIfNull(dataRow);

            object obj = dataRow[column, version];
            if (obj is string s)
            {
                return s;
            }
            return Convert.ToString(obj)!;
        }
    }
}
