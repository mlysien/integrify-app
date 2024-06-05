using Bogus;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

internal sealed class ProductRepository : Faker<Product>, IProductRepository
{
    public ProductRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.Name, f => f.Commerce.ProductName());
        RuleFor(d => d.Price, f => f.Commerce.Random.Number(1,100));
        RuleFor(d => d.Tax, f => 0.23);
        RuleFor(d => d.LastUpdated, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
    }
    public Task<Product> GetProductAsync(Guid id)
    {
        return Task.Run(() => Generate());
    }

    public async Task SaveProductAsync(Product product)
    {
        await Task.Delay(new Random().Next(100, 1000));
    }
}