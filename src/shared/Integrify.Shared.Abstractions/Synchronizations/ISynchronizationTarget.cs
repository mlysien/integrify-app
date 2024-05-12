namespace Integrify.Shared.Abstractions.Synchronizations;

public interface ISynchronizationTarget<in T> where T : SynchronizationEntity
{
    Task SaveEntityAsync(T entity);
}