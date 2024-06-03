namespace Integrify.Shared.Abstractions.Options;

/// <summary>
/// Provides methods for manage files with integration options
/// </summary>
public interface IIntegrationOptionsProvider
{
    /// <summary>
    /// Returns options for specified integration area
    /// </summary>
    /// <param name="integrationArea">Name of integration area</param>
    Task<IntegrationOptions> GetIntegrationOptionsAsync(string integrationArea);
    
    /// <summary>
    /// Updates options for specified integration area
    /// </summary>
    /// <param name="integrationArea">Name of integration area</param>
    /// <param name="options">Integration options entity</param>
    /// <returns></returns>
    Task UpdateIntegrationOptionsAsync(string integrationArea, IntegrationOptions options);
}