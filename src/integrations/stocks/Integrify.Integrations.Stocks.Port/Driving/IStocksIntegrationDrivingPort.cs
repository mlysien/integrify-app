using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Integrations.Stocks.Port.Driving;

public interface IStocksIntegrationDrivingPort
{
    Task<IReadOnlyCollection<StockModel>> GetStocksCollectionAsync();

    Task<StockModel> GetSingleStockAsync(Guid id);
}