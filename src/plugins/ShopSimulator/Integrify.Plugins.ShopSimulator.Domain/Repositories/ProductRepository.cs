using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

internal sealed class ProductRepository : IProductRepository
{
    public async Task SaveProductAsync(Product product)
    {
        await Task.Delay(new Random().Next(100, 1000));
    }
}