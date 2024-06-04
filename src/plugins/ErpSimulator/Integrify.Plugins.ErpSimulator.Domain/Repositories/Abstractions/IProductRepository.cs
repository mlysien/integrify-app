using Integrify.Plugins.ErpSimulator.Domain.Models;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

public interface IProductRepository
{
    Task<List<Product>> GetProductsAsync();
}