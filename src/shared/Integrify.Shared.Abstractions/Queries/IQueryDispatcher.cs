namespace Integrify.Shared.Abstractions.Queries;

/// <summary>
/// Interface for dispatching queries
/// </summary>
public interface IQueryDispatcher
{
    /// <summary>
    /// Dispatching specified query
    /// </summary>
    /// <param name="query">Dispatching query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}