using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Shared.Abstractions.Synchronizations;

/// <summary>
/// Marker interface for handling synchronization processes
/// </summary>
public interface ISynchronizationHandler<in T> : ICommandHandler<T> where T : class, ICommand
{
}