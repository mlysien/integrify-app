using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Integrations.Products.Model;

/// <summary>
/// Represents integration model of product entity 
/// </summary>
public sealed class ProductIntegrationModel : IIntegrationModel
{
    public IntegrationId Id { get; init; }

    public required string Name { get; init; }
    
    
    public string Category { get; init; }
    
    public required double Price { get; init; }
    
    
    public required double TaxRate  { get; init; }
}