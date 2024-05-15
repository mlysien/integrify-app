using Integrify.Integrations.Customers.Core.Services;
using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegration, CustomersIntegration>();
        serviceCollection.AddScoped<ICustomersIntegrationDrivingPort>();
        serviceCollection.AddScoped<ICustomersIntegrationDrivenPort>();
    }
}