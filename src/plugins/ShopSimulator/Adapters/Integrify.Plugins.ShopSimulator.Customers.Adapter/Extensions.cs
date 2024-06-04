using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter;

public static class Extensions
{
    public static void AddCustomersAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationDrivingPort, CustomersShopSimulatorDrivingAdapter>();
    }
}