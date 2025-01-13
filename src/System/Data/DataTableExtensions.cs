namespace System.Data
{
    /// <summary>Provides extension methods for <see cref="T:System.Data.DataTable" />.</summary>
    public static class DataTableExtensions
    {
        public static void ClearAndDispose(this DataTable? dataTable)
        {
            if (dataTable is not null)
            {
                dataTable.Clear();
                dataTable.Dispose();
            }
        }

        public static DataRow? FindRow(this DataTable dataTable, string columnName, Predicate<object?> match)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataTable);
#else
            Throw.IfNull(dataTable);
#endif
#if NET8_0_OR_GREATER
            ArgumentException.ThrowIfNullOrEmpty(columnName);
#else
            Throw.IfNullOrEmpty(columnName);
#endif
#if NET
            ArgumentNullException.ThrowIfNull(match);
#else
            Throw.IfNull(match);
#endif
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow row in dataTable.Rows)
            {
                if (match(row[columnName]))
                {
                    return row;
                }
            }
            return null;
        }

        public static int GetChangeCount(this DataTable dataTable)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataTable);
#else
            Throw.IfNull(dataTable);
#endif
            int changes = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if ((row.RowState & (DataRowState.Modified | DataRowState.Deleted | DataRowState.Added)) != 0)
                    changes++;
            }
            return changes;
        }

        public static bool HasChanges(this DataTable dataTable)
        {
#if NET
            ArgumentNullException.ThrowIfNull(dataTable);
#else
            Throw.IfNull(dataTable);
#endif
            foreach (DataRow row in dataTable.Rows)
            {
                if ((row.RowState & (DataRowState.Modified | DataRowState.Deleted | DataRowState.Added)) != 0)
                    return true;
            }
            return false;
        }

        public static bool IsNullOrEmpty(this DataTable? dataTable)
        {
            return dataTable is null || dataTable.Rows.Count == 0;
        }
    }
}
