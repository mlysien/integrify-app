using Microsoft.AspNetCore.Builder;
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
    /// Module version
    /// </summary>
    Version? Version { get; }
    
    /// <summary>
    /// Registers module dependencies
    /// </summary>
    void Register(IServiceCollection services);
    
    /// <summary>
    /// Adds module middleware 
    /// </summary>
    void Use(IApplicationBuilder app);
}