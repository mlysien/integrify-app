using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Modules;

/// <summary>
/// Marker interface for modules
/// </summary>
public interface IModule
{
    /// <summary>
    /// Module name
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

    /// <summary>
    /// Load configuration section of module
    /// </summary>
    /// <param name="configurationSection">Module configuration section</param>
    void Configure(IConfigurationSection configurationSection);
}