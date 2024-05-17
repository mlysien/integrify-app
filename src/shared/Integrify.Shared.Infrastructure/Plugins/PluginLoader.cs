using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Shared.Infrastructure.Plugins;

internal static class PluginLoader
{
    public static IList<IPlugin> LoadPlugins(string assemblyPrefix)
    {
        var assemblies = AssembliesLoader.Load(assemblyPrefix);
        
        return assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IPlugin).IsAssignableFrom(x) && !x.IsInterface)
            .OrderBy(x => x.Name)
            .Select(Activator.CreateInstance)
            .Cast<IPlugin>()
            .ToList();
    }
}