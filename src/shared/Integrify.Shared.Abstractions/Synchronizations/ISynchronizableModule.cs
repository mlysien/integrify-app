using Integrify.Shared.Abstractions.Modules;

namespace Integrify.Shared.Abstractions.Synchronizations;

/// <summary>
/// Marker interface of modules for synchronization process
/// </summary>
public interface ISynchronizableModule : IModule
{
    /// <summary>
    /// Synchronization direction
    /// </summary>
    SynchronizationDirection Direction { get; }
}