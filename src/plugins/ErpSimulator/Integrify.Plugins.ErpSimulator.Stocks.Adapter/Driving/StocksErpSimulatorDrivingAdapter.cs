using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driving;

public class StocksErpSimulatorDrivingAdapter : IStocksIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<StockIntegrationModel>> FetchCollectionAsync()
    {
        return await Task.Run(() => new List<StockIntegrationModel>
        {
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                Amount = 100
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                Amount = 4
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                Amount = 12
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                Amount = 39
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                Amount = 41
            }
        });
    }

    public async Task<StockIntegrationModel> GetSingleAsync(Guid id)
    {
        return await Task.Run(() => new StockIntegrationModel()
        {
            Id = new IntegrationId(Guid.NewGuid()),
            Amount = 100
        });
    }
}