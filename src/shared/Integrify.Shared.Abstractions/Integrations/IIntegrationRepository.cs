using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// Interface provide methods for get required data for integration area
/// </summary>
public interface IIntegrationRepository
{
    /// <summary>
    /// Returns timestamp of last integration
    /// </summary>
    Task<IntegrationTimestamp> GetLastIntegrationTimestamp();
    
    /// <summary>
    /// Updates timestamp of last integration
    /// </summary>
    /// <param name="timestamp">New timestamp</param>
    Task UpdateLastIntegrationTimestamp(IntegrationTimestamp timestamp);
}