using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Integrations.Stocks.Port.Driving;

public interface IStocksIntegrationDrivingPort
{
    Task<IReadOnlyCollection<StockIntegrationModel>> GetStocksCollectionAsync();

    Task<StockIntegrationModel> GetSingleStockAsync(Guid id);
}