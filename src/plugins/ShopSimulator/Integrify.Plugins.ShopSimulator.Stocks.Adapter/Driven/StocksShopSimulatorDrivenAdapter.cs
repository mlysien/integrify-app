using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driven;

internal sealed class StocksShopSimulatorDrivenAdapter : IStocksIntegrationDrivenPort
{
    public Task SaveStockAsync(StockIntegrationModel stockIntegrationModel)
    {
        return Task.CompletedTask;
    }
}