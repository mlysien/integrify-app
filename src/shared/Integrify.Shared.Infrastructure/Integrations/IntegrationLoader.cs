using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Infrastructure.Integrations;

internal static class IntegrationLoader
{
    public static IList<IIntegration> LoadIntegrations(string assemblyPrefix)
    {
        var assemblies = AssembliesLoader.Load(assemblyPrefix);
        
        return assemblies
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(IIntegration).IsAssignableFrom(x) && !x.IsInterface)
            .OrderBy(x => x.Name)
            .Select(Activator.CreateInstance)
            .Cast<IIntegration>()
            .ToList();
    }
}