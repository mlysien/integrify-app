using Bogus;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories;

internal sealed class ProductRepository : Faker<Product>, IProductRepository
{
    public ProductRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.Name, f => f.Commerce.ProductName());
        RuleFor(d => d.Description, f => f.Commerce.ProductDescription());
        RuleFor(d => d.Category, f => f.Commerce.Categories(1).First());
        RuleFor(d => d.Price, f => f.Commerce.Random.Number(1,100));
        RuleFor(d => d.Tax, f => 0.23);
        RuleFor(d => d.LastUpdated, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
    }
    
    public Task<List<Product>> GetProductsAsync()
    {
        return Task.Run(() => Generate(20));
    }

    public Task<Product> GetProductAsync(Guid id)
    {
        return Task.Run(() => Generate());
    }
}