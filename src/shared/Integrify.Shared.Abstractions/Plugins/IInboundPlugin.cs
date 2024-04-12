namespace Integrify.Shared.Abstractions.Plugins;

/// <summary>
/// Represents inbound type plugin
/// </summary>
public interface IInboundPlugin : IPlugin
{
    Task<IReadOnlyCollection<TOrder>> GetOrdersAsync<TOrder>() where TOrder : class, IOrderContract;
    
    Task<IReadOnlyCollection<TStock>> GetStocksAsync<TStock>() where TStock : class, IStockContract;
    
}