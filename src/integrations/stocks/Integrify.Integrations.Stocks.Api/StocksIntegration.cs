using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Integrations.Stocks.Api.Services;
using Integrify.Integrations.Stocks.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Stocks.Api;

internal sealed class StocksIntegration : IIntegration
{
    public string Name => "Stocks";
    
    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStocksIntegrationApi, StocksIntegrationApi>();
        serviceCollection.AddStocksIntegrationCoreLayer();
    }
}