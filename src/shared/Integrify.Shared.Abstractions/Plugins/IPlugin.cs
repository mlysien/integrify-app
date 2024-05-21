using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Marker interface for plugins
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Plugin name
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// Add all dependencies required by the plugin
    /// </summary>
    /// <param name="serviceCollection">Service collection</param>
    void AddPluginDependencies(IServiceCollection serviceCollection);
}