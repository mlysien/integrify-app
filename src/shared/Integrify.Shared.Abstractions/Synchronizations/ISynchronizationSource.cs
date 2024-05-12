namespace Integrify.Shared.Abstractions.Synchronizations;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISynchronizationSource<T> where T : SynchronizationEntity
{
    Task<IReadOnlyCollection<T>> GetCollectionAsync();

    Task<T> GetSingle(SynchronizationId id);
}