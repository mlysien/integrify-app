using Integrify.Integrations.Stocks.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Stocks.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegration, StocksIntegration>();
    }
}