using Integrify.Shared.Abstractions.Options;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Shared.Abstractions.Integrations;

/// <summary>
/// 
/// </summary>
public interface IIntegrationRepository
{
    public string IntegrationArea { get; }
    
    Task<IntegrationTimestamp> GetLastIntegrationTimestampAsync();
    
    Task UpdateIntegrationTimestampAsync();
}