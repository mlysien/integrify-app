using Integrify.Integrations.Stocks.Port.Models;

namespace Integrify.Integrations.Stocks.Port.Driven;

public interface IStocksIntegrationDrivenPort
{
    Task SaveStockAsync(StockIntegrationModel stockIntegrationModel);
}