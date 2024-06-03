using Integrify.Integrations.Stocks.Core.Abstractions;
using Integrify.Integrations.Stocks.Core.Process;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Stocks.Core;

public static class Extensions
{
    public static void AddStocksIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegrationProcess, StocksIntegrationProcess>();
    }
}