using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driving;

public class StocksErpSimulatorDrivingAdapter : IStocksIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<StockIntegrationModel>> GetStocksCollectionAsync()
    {
        return await Task.Run(() => new List<StockIntegrationModel>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Amount = 100
            },
            new()
            {
                Id = Guid.NewGuid(),
                Amount = 4
            },
            new()
            {
                Id = Guid.NewGuid(),
                Amount = 12
            },
            new()
            {
                Id = Guid.NewGuid(),
                Amount = 39
            },
            new()
            {
                Id = Guid.NewGuid(),
                Amount = 41
            }
        });
    }

    public async Task<StockIntegrationModel> GetSingleStockAsync(Guid id)
    {
        return await Task.Run(() => new StockIntegrationModel()
        {
            Id = Guid.NewGuid(),
            Amount = 100
        });
    }
}