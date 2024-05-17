using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Plugins;

public static class Extensions
{
    public static void AddPlugins(this IServiceCollection serviceCollection, string assemblyPrefix)
    {
        var pluginsList = PluginLoader.LoadPlugins(assemblyPrefix);

        serviceCollection.AddSingleton(pluginsList);
        
        foreach (var plugin in pluginsList)
        {
            plugin.AddPluginDependencies(serviceCollection);
        }
    }
}