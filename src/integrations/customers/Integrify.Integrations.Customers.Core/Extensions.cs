using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Integrations.Customers.Core.Process;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Core;

public static class Extensions
{
    public static void AddCustomersIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationProcess, CustomersIntegrationProcess>();
    }
}