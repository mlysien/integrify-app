using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Provides methods for manage integration data
/// </summary>
public interface IIntegrationRepository
{
    /// <summary>
    /// Returns name of integration area
    /// </summary>
    public string IntegrationArea { get; }
    
    /// <summary>
    /// Returns timestamp of last integration
    /// </summary>
    Task<IntegrationTimestamp> GetLastIntegrationTimestampAsync();
    
    /// <summary>
    /// Updates timestamp of last integration
    /// </summary>
    Task UpdateIntegrationTimestampAsync();
}