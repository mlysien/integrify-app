using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Stocks.Model;
using Integrify.Integrations.Stocks.Port.Driving;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Stocks.Adapter.Driving;

internal sealed class StocksErpSimulatorDrivingAdapter(IStockRepository repository) : IStocksIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<StockIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        var integrationModels = new List<StockIntegrationModel>();
        var stocks = await repository.GetStocksAsync();
        
        foreach (var stock in stocks)
        {
            if (stock.LastUpdated.Ticks >= timestamp.Ticks)
            {
                integrationModels.Add(new StockIntegrationModel()
                {
                    Id = new IntegrationId(stock.Id),
                    Amount = stock.Amount,
                    Product = new ProductIntegrationModel()
                    {
                        Id = new IntegrationId(stock.Product.Id),
                        Name = stock.Product.Name,
                        Price = stock.Product.Price,
                        TaxRate = stock.Product.Tax,
                        Category = stock.Product.Category
                    }
                });
            }
        }

        return integrationModels;
    }

    public async Task<StockIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        var stock = await repository.GetStockAsync(id.Value);
        
        return new StockIntegrationModel
        {
            Id = id,
            Amount = stock.Amount,
            Product = new ProductIntegrationModel()
            {
                Id = new IntegrationId(stock.Product.Id),
                Name = stock.Product.Name,
                Price = stock.Product.Price,
                TaxRate = stock.Product.Tax,
                Category = stock.Product.Category
            }
        };
    }
}