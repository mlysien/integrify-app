using Microsoft.AspNetCore.Builder;
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
    /// Registers module dependencies
    /// </summary>
    void Register(IServiceCollection services);
    
    /// <summary>
    /// Adds module middleware 
    /// </summary>
    void Use(IApplicationBuilder app);
}