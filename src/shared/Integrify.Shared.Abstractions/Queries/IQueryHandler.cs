namespace Integrify.Shared.Abstractions.Queries;

/// <summary>
/// Interface for handling queries
/// </summary>
public interface IQueryHandler<in TQuery, TResult> where TQuery : class, IQuery<TResult>
{
    /// <summary>
    /// Handling specified query
    /// </summary>
    /// <param name="query">Handling query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken = default);
}