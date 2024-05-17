using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Integrations.Stocks.Core.Services;

namespace Integrify.Integrations.Stocks.Api.Services;

internal sealed class StocksIntegrationApi(IStocksIntegrationProcess integrationProcess) : IStocksIntegrationApi
{
    public async Task RunIntegration()
    {
        await integrationProcess.ExecuteIntegrationProcess();
    }
}