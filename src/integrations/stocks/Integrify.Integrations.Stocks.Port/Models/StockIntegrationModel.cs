using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Integrations.Stocks.Port.Models;

/// <summary>
/// Represents integration model of stock entity 
/// </summary>
public sealed class StockIntegrationModel : IIntegrationModel
{
    public Guid Id { get; set; }

    public double Amount { get; set; }
}