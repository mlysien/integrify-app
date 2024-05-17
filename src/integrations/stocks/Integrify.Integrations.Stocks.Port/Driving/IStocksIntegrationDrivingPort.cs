using Integrify.Integrations.Stocks.Port.Models;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Stocks.Port.Driving;

/// <summary>
/// Marker interface for stocks integration driving port
/// </summary>
public interface IStocksIntegrationDrivingPort : IDrivingPort<StockIntegrationModel>;