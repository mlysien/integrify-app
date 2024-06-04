using Integrify.Plugins.ShopSimulator.Domain.Models;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

public interface IStockRepository
{
    Task SaveStockAsync(Stock stock);
}