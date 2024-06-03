using Integrify.Shared.Abstractions.Initializer;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Options;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Initializer;

internal sealed class Initializer(
    ILogger<Initializer> logger,
    IList<IIntegrationArea> integrationAreas,
    IIntegrationOptionsProvider optionsProvider)
    : IInitializer
{
    public async Task InitializeAsync()
    {
        var directory= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Integrify");
        
        if (!Directory.Exists(directory))
        {
            logger.LogWarning("{dir} config directory doesn't exist", "Integrify");
            
            Directory.CreateDirectory(directory);
            
            logger.LogInformation("{dir} config directory created", "Integrify");
        }
        
        foreach (var integrationArea in integrationAreas)
        {
            var path = Path.Combine(directory, $"{integrationArea.Name.ToLower()}.integration.json");

            if (!File.Exists(path))
            {
                logger.LogWarning("Not found config file for {area}", integrationArea.Name.ToLower());
                
                await optionsProvider.UpdateIntegrationOptions(integrationArea.Name, new IntegrationOptions());
                
                logger.LogInformation("{file} created", $"{integrationArea.Name.ToLower()}.integration.json");
            }
        }
    }
}