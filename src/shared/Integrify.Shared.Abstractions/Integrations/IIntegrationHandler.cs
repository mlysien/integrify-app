using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Marker interface for handling integrations processes
/// </summary>
public interface IIntegrationHandler<in T> : ICommandHandler<T> where T : class, IIntegration
{
}