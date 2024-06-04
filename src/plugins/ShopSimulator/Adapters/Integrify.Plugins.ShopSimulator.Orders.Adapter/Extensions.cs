using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Plugins.ShopSimulator.Orders.Adapter.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter;

public static class Extensions
{
    public static void AddOrdersAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegrationDrivingPort, OrdersShopSimulatorDrivingAdapter>();
    }
}