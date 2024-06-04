using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

internal sealed class StockRepository : IStockRepository
{
    public async Task SaveStockAsync(Stock stock)
    {
        await Task.Delay(new Random().Next(100, 1000));
    }
}