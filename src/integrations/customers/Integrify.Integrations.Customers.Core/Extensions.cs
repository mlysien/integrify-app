using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Integrations.Customers.Core.Process;
using Integrify.Integrations.Customers.Core.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Core;

public static class Extensions
{
    public static void AddCustomersIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationProcess, CustomersIntegrationProcess>();
        serviceCollection.AddScoped<ICustomersIntegrationRepository, CustomersIntegrationRepository>();
    }
}