namespace System.Data
{
    /// <summary>
    /// Represents an abstract base class for database converters that manage and apply updates
    /// to a database schema. This class provides the framework for version control, schema
    /// retrieval, update requirements, and applying updates.
    /// </summary>
    /// <typeparam name="TDbConnection">The type of the database connection.</typeparam>
    public abstract class DbConverter<TDbConnection> where TDbConnection : IDbConnection
    {
        #region Properties

        /// <summary>
        /// Gets the version of the database schema that this converter is designed to update to.
        /// </summary>
        public abstract Version Version { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves the current version of the database schema from the specified database connection.
        /// </summary>
        /// <param name="connection">The database connection to use for retrieving the version.</param>
        /// <returns>The current version of the database schema.</returns>
        public abstract Version GetDbVersion(TDbConnection connection);

        /// <summary>
        /// Determines whether the database requires an update to match the version specified by this converter.
        /// </summary>
        /// <param name="connection">The database connection to check.</param>
        /// <returns><c>true</c> if the database requires an update; otherwise, <c>false</c>.</returns>
        public virtual bool RequiresUpdate(TDbConnection connection)
        {
            Version dbVersion = GetDbVersion(connection);
            return dbVersion < Version;
        }

        /// <summary>
        /// Applies the necessary updates to the database to bring it in line with the version specified by this converter.
        /// </summary>
        /// <param name="connection">The database connection to update.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public abstract bool Update(TDbConnection connection);

        #endregion
    }
}
