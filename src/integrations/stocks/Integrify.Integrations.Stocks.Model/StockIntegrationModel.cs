using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Stocks.Model;

/// <summary>
/// Represents integration model of stock entity 
/// </summary>
public sealed class StockIntegrationModel : IIntegrationModel
{
    public IntegrationId Id { get; set; }

    public double Amount { get; set; }
}