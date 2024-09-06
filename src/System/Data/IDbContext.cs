namespace System.Data
{
    /// <summary>
    /// Represents a database context that provides a connection to the database
    /// and supports transaction management through commit and rollback operations.
    /// </summary>
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// Gets the database connection associated with this context.
        /// </summary>
        IDbConnection Connection { get; }

        /// <summary>
        /// Commits all changes made in this context to the database.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rolls back all changes made in this context.
        /// </summary>
        void Rollback();
    }
}
