using System.Reflection;
using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Infrastructure.Integrations;

public static class IntegrationLoader
{
    public static IList<IIntegration> LoadIntegrations(string assemblyPrefix)
    {
        var assemblies = LoadAssemblies(assemblyPrefix);
        
        return assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IIntegration).IsAssignableFrom(x) && !x.IsInterface)
            .OrderBy(x => x.Name)
            .Select(Activator.CreateInstance)
            .Cast<IIntegration>()
            .ToList();
    }
    
    private static IList<Assembly> LoadAssemblies(string assemblyPrefix)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
        var locations = assemblies.Where(x => !x.IsDynamic).Select(x => x.Location).ToArray();
        var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
            .Where(x => !locations.Contains(x, StringComparer.InvariantCultureIgnoreCase))
            .ToList();
        
        var assembliesToDelete = files.Where(file => !file.Contains(assemblyPrefix)).ToList();

        foreach (var assembly in assembliesToDelete)
        {
            files.Remove(assembly);
        }
        
        files.ForEach(x => assemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(x))));

        return assemblies;
    }

}