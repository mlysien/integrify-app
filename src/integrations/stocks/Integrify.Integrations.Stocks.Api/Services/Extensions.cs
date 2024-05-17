using Integrify.Integrations.Stocks.Api.Public;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Stocks.Api.Services;

internal static class Extensions
{
    public static void AddStocksIntegrationApi(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegrationApi, StocksIntegrationApi>();
    }
}