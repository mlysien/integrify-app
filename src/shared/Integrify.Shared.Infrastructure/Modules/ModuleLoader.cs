using System.Reflection;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.Configuration;

namespace Integrify.Shared.Infrastructure.Modules;

public static class ModuleLoader
{
    public static IList<Assembly> LoadModulesAssemblies(IConfiguration configuration, string modulePart)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
        var locations = assemblies.Where(x => !x.IsDynamic).Select(x => x.Location).ToArray();
        var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
            .Where(x => !locations.Contains(x, StringComparer.InvariantCultureIgnoreCase))
            .ToList();

        var disabledModules = new List<string>();
        foreach (var file in files)
        {
            if (!file.Contains(modulePart))
            {
                continue;
            }

            var moduleName = file.Split(modulePart)[1].Split(".")[0].ToLowerInvariant();
            var enabled = configuration.GetValue<bool>($"{moduleName}:module:enabled");
            if (!enabled)
            {
                disabledModules.Add(file);
            }
        }

        foreach (var disabledModule in disabledModules)
        {
            files.Remove(disabledModule);
        }
            
        files.ForEach(x => assemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(x))));

        return assemblies;
    }
    
    // todo move to separate Loader
    public static IList<Assembly> LoadPluginsAssemblies(IConfiguration configuration, string pluginPart)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
        var locations = assemblies.Where(x => !x.IsDynamic).Select(x => x.Location).ToArray();
        var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
            .Where(x => !locations.Contains(x, StringComparer.InvariantCultureIgnoreCase))
            .ToList();

        var disabledModules = new List<string>();
        foreach (var file in files)
        {
            if (!file.Contains(pluginPart))
            {
                continue;
            }

            var pluginName = file.Split(pluginPart)[1].Split(".")[0].ToLowerInvariant();
            var enabled = configuration.GetValue<bool>($"{pluginName}:plugin:enabled");
            
            if (!enabled)
            {
                disabledModules.Add(file);
            }
        }

        foreach (var disabledModule in disabledModules)
        {
            files.Remove(disabledModule);
        }
            
        files.ForEach(x => assemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(x))));

        return assemblies;
    }
    
    public static IList<IModule> LoadModules(IEnumerable<Assembly> assemblies)
        => assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IModule).IsAssignableFrom(x) && !x.IsInterface)
            .OrderBy(x => x.Name)
            .Select(Activator.CreateInstance)
            .Cast<IModule>()
            .ToList();
    
    public static IList<IPlugin> LoadPlugins(IEnumerable<Assembly> assemblies)
        => assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IPlugin).IsAssignableFrom(x) && !x.IsInterface)
            .OrderBy(x => x.Name)
            .Select(Activator.CreateInstance)
            .Cast<IPlugin>()
            .ToList();
}