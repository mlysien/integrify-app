using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Integrations;

public static class Extensions
{
    public static void AddIntegrations(this IServiceCollection serviceCollection, string assemblyPrefix)
    {
        var integrationsList = IntegrationLoader.LoadIntegrations(assemblyPrefix);
        
        serviceCollection.AddSingleton(integrationsList);
        
        foreach (var integration in integrationsList)
        {
            integration.AddIntegrationDependencies(serviceCollection);
        }
    }
}