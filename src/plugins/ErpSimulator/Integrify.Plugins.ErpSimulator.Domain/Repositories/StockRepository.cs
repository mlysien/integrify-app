using Bogus;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories;

internal sealed class StockRepository : Faker<Stock>, IStockRepository
{
    public StockRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.Product, f => new Product
        {
            Id = Guid.NewGuid(),
            Name = f.Commerce.Product(),
            Category = f.Commerce.Categories(1).First(),
            Description = f.Commerce.ProductDescription()
        });
        RuleFor(d => d.Amount, f => f.Random.Number(1, 20));
        RuleFor(d => d.LastUpdated, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
    }
    
    public Task<List<Stock>> GetStocksAsync()
    {
        return Task.Run(() => Generate(10));
    }

    public Task<Stock> GetStockAsync(Guid id)
    {
        return Task.Run(() => Generate());
    }
}