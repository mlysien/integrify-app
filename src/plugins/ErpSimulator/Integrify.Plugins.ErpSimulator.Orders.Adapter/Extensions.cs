using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Plugins.ErpSimulator.Orders.Adapter.Driven;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter;

public static class Extensions
{
    public static void AddOrdersAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegrationDrivenPort, OrdersErpSimulatorDrivenAdapter>();
    }
}