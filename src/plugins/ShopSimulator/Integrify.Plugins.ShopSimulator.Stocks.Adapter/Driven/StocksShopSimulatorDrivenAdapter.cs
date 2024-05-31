using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driven;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driven;

internal sealed class StocksShopSimulatorDrivenAdapter : IStocksIntegrationDrivenPort
{
    public Task PushAsync(StockIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}