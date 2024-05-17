using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driving;

internal sealed class StocksShopSimulatorDrivingAdapter : IStocksIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<StockIntegrationModel>> GetStocksCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StockIntegrationModel> GetSingleStockAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}