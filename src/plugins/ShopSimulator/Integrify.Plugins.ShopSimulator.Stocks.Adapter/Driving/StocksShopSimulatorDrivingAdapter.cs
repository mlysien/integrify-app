using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driving;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driving;

internal sealed class StocksShopSimulatorDrivingAdapter : IStocksIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<StockIntegrationModel>> FetchCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StockIntegrationModel> GetSingleAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}