using Integrify.Integrations.Stocks.Model;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Stocks.Port.Driven;

/// <summary>
/// Marker interface for stocks integration driven port
/// </summary>
public interface IStocksIntegrationDrivenPort : IDrivenPort<StockIntegrationModel>;