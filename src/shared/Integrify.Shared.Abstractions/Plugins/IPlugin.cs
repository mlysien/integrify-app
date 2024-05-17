using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Plugins;

public interface IPlugin
{
    void AddPluginDependencies(IServiceCollection serviceCollection);
}