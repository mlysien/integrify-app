using Integrify.Plugins.ErpSimulator.Domain.Models;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

public interface IStockRepository
{
    Task<List<Stock>> GetStocksAsync();
}