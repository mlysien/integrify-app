namespace Integrify.Shared.Abstractions.Synchronizations;

/// <summary>
/// Represents direction of synchronization process
/// </summary>
/// <param name="Source">Sourced system</param>
/// <param name="Target">Target system</param>
public record SynchronizationDirection(SynchronizationSystems Source, SynchronizationSystems Target);