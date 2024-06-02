using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driving;

internal sealed class StocksShopSimulatorDrivingAdapter : IStocksIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<StockIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }

    public Task<StockIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        throw new NotImplementedException();
    }
}