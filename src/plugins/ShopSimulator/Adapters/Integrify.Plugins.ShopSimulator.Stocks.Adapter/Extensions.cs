using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driven;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter;

public static class Extensions
{
    public static void AddStocksAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegrationDrivenPort, StocksShopSimulatorDrivenAdapter>();
    }
}