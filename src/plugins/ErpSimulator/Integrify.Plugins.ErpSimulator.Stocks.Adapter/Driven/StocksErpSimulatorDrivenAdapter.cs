using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driven;

public class StocksErpSimulatorDrivenAdapter : IStocksIntegrationDrivenPort
{
    public Task SaveStockAsync(StockModel stockModel)
    {
        throw new NotImplementedException();
    }
}