namespace Integrify.Integrations.Products.Port.Models;

/// <summary>
/// 
/// </summary>
public sealed class ProductModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public double Price { get; set; }
}