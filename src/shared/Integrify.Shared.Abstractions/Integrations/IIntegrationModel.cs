namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Marker interface for integration model object 
/// </summary>
public interface IIntegrationModel
{
    /// <summary>
    /// Unique model identifier
    /// </summary>
    Guid Id { get; }
}
