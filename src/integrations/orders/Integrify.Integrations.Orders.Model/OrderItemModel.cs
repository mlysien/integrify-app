using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Orders.Model;

/// <summary>
/// Represents order item
/// </summary>
public sealed class OrderItemModel
{
    public IntegrationId ProductId { get; init; }

    public double ProductAmount { get; init; }

    public double ProductPrice { get; init; }
}