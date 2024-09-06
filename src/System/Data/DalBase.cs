using System.Diagnostics.CodeAnalysis;

namespace System.Data
{
    /// <summary>
    /// Represents an abstract base class for Data Access Layer (DAL) operations,
    /// providing a framework for database context management and execution of database-related actions.
    /// </summary>
    /// <typeparam name="TDbContext">The type of the database context.</typeparam>
    public abstract class DalBase<TDbContext> : Disposable where TDbContext : IDbContext
    {
        protected DalBase()
        {
        }

        #region Properties

        /// <summary>
        /// Gets the list of columns relevant to the specific implementation of the derived class.
        /// This property should be overridden in derived classes to specify the columns of the database table that the class interacts with.
        /// </summary>
        protected abstract string[] Columns { get; }

        /// <summary>
        /// Gets the name of the table associated with the specific implementation of the derived class.
        /// This property should be overridden in derived classes to specify the name of the database table that the class interacts with.
        /// </summary>
        protected abstract string TableName { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Creates and initializes an instance of the database context.
        /// </summary>
        /// <returns>An instance of <typeparamref name="TDbContext"/>.</returns>
        protected abstract TDbContext CreateDbContext();

        /// <summary>
        /// Attempts to create and assign a new instance of the database context if it is not already initialized.
        /// </summary>
        /// <param name="context">Reference to the database context.</param>
        /// <returns><c>true</c> if a new context was created; otherwise, <c>false</c>.</returns>
        protected bool TryCreateDbContext([NotNull] ref TDbContext? context)
        {
            if (context != null) return false;
            context = CreateDbContext();
            return true;
        }

        /// <summary>
        /// Executes an action within a database context, ensuring that the context is managed (created, committed, or rolled back) accordingly.
        /// </summary>
        /// <param name="context">Optional existing context.</param>
        /// <param name="action">The action to perform within the context.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="action"/> is null.
        /// </exception>
        protected virtual ValueTask TryExecuteInDbContextAsync(TDbContext? context, Action<TDbContext> action, CancellationToken cancellationToken = default)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(action);
#else
            Throw.IfNull(action);
#endif
            bool contextTaken = TryCreateDbContext(ref context);
            try
            {
                action(context);
                if (contextTaken)
                {
                    context.Commit();
                }
                return default;
            }
            catch
            {
                if (contextTaken)
                {
                    context.Rollback();
                }
                throw;
            }
            finally
            {
                if (contextTaken)
                {
                    context.Dispose();
                }
            }
        }

        /// <summary>
        /// Asynchronously executes a function within a database context, ensuring that the context is managed (created, committed, or rolled back) accordingly.
        /// </summary>
        /// <param name="context">Optional existing context.</param>
        /// <param name="action">The asynchronous function to perform within the context.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="action"/> is null.
        /// </exception>
        protected virtual async ValueTask TryExecuteInDbContextAsync(TDbContext? context, Func<TDbContext, ValueTask> action, CancellationToken cancellationToken = default)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(action);
#else
            Throw.IfNull(action);
#endif
            bool contextTaken = TryCreateDbContext(ref context);
            try
            {
                await action(context);
                if (contextTaken)
                {
                    context.Commit();
                }
            }
            catch
            {
                if (contextTaken)
                {
                    context.Rollback();
                }
                throw;
            }
            finally
            {
                if (contextTaken)
                {
                    context.Dispose();
                }
            }
        }

        /// <summary>
        /// Executes a function within a database context and returns a result, ensuring that the context is managed (created, committed, or rolled back) accordingly.
        /// </summary>
        /// <typeparam name="T">The type of the result produced by the function.</typeparam>
        /// <param name="context">Optional existing context.</param>
        /// <param name="func">The function to perform within the context.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="ValueTask{T}"/> containing the result of the function.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="func"/> is null.
        /// </exception>
        protected virtual ValueTask<T> TryExecuteInDbContextAsync<T>(TDbContext? context, Func<TDbContext, T> func, CancellationToken cancellationToken = default)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(func);
#else
            Throw.IfNull(func);
#endif
            bool contextTaken = TryCreateDbContext(ref context);
            try
            {
                T result = func(context);
                if (contextTaken)
                {
                    context.Commit();
                }
                return new ValueTask<T>(result);
            }
            catch
            {
                if (contextTaken)
                {
                    context.Rollback();
                }
                throw;
            }
            finally
            {
                if (contextTaken)
                {
                    context.Dispose();
                }
            }
        }

        /// <summary>
        /// Asynchronously executes a function within a database context and returns a result, ensuring that the context is managed (created, committed, or rolled back) accordingly.
        /// </summary>
        /// <typeparam name="T">The type of the result produced by the function.</typeparam>
        /// <param name="context">Optional existing context.</param>
        /// <param name="func">The asynchronous function to perform within the context.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="ValueTask{T}"/> containing the result of the asynchronous function.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="func"/> is null.
        /// </exception>
        protected virtual async ValueTask<T> TryExecuteInDbContextAsync<T>(TDbContext? context, Func<TDbContext, ValueTask<T>> func, CancellationToken cancellationToken = default)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(func);
#else
            Throw.IfNull(func);
#endif
            bool contextTaken = TryCreateDbContext(ref context);
            try
            {
                T result = await func(context);
                if (contextTaken)
                {
                    context.Commit();
                }
                return result;
            }
            catch
            {
                if (contextTaken)
                {
                    context.Rollback();
                }
                throw;
            }
            finally
            {
                if (contextTaken)
                {
                    context.Dispose();
                }
            }
        }

        #endregion
    }
}
