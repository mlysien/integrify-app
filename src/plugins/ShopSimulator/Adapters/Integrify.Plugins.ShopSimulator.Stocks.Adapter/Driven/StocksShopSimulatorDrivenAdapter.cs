using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driven;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.Time;

namespace Integrify.Plugins.ShopSimulator.Stocks.Adapter.Driven;

internal sealed class StocksShopSimulatorDrivenAdapter(
    IClock clock, 
    IStockRepository repository)
    : IStocksIntegrationDrivenPort
{
    public async Task PushAsync(StockIntegrationModel integrationModel)
    {
        var stock = new Stock()
        {
            Id = integrationModel.Id.Value,
            Amount = integrationModel.Amount,
            LastUpdated = clock.NowDateTime()
        };

        await repository.SaveStockAsync(stock);
    }
}