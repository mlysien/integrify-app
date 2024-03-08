namespace Integrify.Shared.Abstractions.Queries;

/// <summary>
/// Marker interface for queries
/// </summary>
public interface IQuery
{
}

/// <summary>
/// Marker interface for generic queries
/// </summary>
public interface IQuery<T> : IQuery
{
}