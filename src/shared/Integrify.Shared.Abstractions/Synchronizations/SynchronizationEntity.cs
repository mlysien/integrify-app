namespace Integrify.Shared.Abstractions.Synchronizations;

public abstract class SynchronizationEntity(SynchronizationId id)
{
    public SynchronizationId Id { get; set; } = id;
}

public abstract record SynchronizationId(Guid Id);