using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Plugins;

public interface IPlugin
{
    string Name { get; }
    
    void AddPluginDependencies(IServiceCollection serviceCollection);
}