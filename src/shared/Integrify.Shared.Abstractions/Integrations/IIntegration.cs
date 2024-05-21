using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Interface for define integration 
/// </summary>
public interface IIntegration
{
    /// <summary>
    /// Integration name
    /// </summary>
    string Name { get; }
 
    /// <summary>
    /// Add all dependencies required by the integration
    /// </summary>
    /// <param name="serviceCollection">Service collection</param>
    void AddIntegrationDependencies(IServiceCollection serviceCollection);
}