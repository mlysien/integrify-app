using Integrify.Integrations.Customers.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegration, CustomersIntegration>();
    }
}