using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter;

public static class Extensions
{
    public static void AddStocksAdapters(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegrationDrivingPort, StocksErpSimulatorDrivingAdapter>();
    }
}