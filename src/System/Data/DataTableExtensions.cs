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
            ArgumentNullException.ThrowIfNull(dataTable);
            ArgumentException.ThrowIfNullOrEmpty(columnName);
            ArgumentNullException.ThrowIfNull(match);

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
            ArgumentNullException.ThrowIfNull(dataTable);

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
            ArgumentNullException.ThrowIfNull(dataTable);

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
