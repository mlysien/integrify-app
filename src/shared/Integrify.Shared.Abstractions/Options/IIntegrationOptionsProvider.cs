namespace Integrify.Shared.Abstractions.Options;

public interface IIntegrationOptionsProvider
{
    Task<IntegrationOptions> GetIntegrationOptions(string integrationArea);
    
    Task UpdateIntegrationOptions(string integrationArea, IntegrationOptions options);
}