using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Stocks.Model;

/// <summary>
/// Represents integration model of stock entity 
/// </summary>
public sealed class StockIntegrationModel : IIntegrationModel
{
    public required IntegrationId Id { get; init; }

    public required IntegrationId ProductId { get; init; }

    public required string ProductName { get; init; }
    
    public double StockAmmount { get; init; }
}