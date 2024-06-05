using Integrify.Plugins.ShopSimulator.Domain.Models;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

public interface IProductRepository
{
    Task<Product> GetProductAsync(Guid id);
    
    Task SaveProductAsync(Product product);
}