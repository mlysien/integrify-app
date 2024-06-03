using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Integrations.Stocks.Core.Abstractions;

namespace Integrify.Integrations.Stocks.Api.Services;

internal sealed class StocksIntegrationApi(IStocksIntegrationProcess integrationProcess) : IStocksIntegrationApi
{
    public async Task RunIntegrationAsync()
    {
        await integrationProcess.ExecuteIntegrationProcessAsync();
    }
}