using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Products.Model;

/// <summary>
/// Represents integration model of product entity 
/// </summary>
public sealed class ProductIntegrationModel : IIntegrationModel
{
    public IntegrationId Id { get; set; }

    public required string Name { get; set; }

    public double Price { get; set; }
}