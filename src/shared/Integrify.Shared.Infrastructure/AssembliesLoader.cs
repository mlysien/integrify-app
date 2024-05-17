using System.Reflection;

namespace Integrify.Shared.Infrastructure;

internal class AssembliesLoader
{
    public static IList<Assembly> Load(string assemblyPrefix)
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