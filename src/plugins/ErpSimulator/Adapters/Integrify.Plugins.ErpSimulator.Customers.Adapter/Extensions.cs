using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter;

public static class Extensions
{
    public static void AddCustomersAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationDrivenPort, CustomersErpSimulatorDrivenAdapter>();
    }
}