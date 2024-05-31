using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driven;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driven;

public class StocksErpSimulatorDrivenAdapter : IStocksIntegrationDrivenPort
{
    public Task PushAsync(StockIntegrationModel integrationModel)
    {
        throw new NotImplementedException();
    }
}