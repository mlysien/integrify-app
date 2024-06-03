using System.Text.Json;
using Integrify.Shared.Abstractions.Options;

namespace Integrify.Shared.Infrastructure.Options;

internal sealed class IntegrationOptionsProvider : IIntegrationOptionsProvider
{
    public async Task<IntegrationOptions> GetIntegrationOptionsAsync(string integrationArea)
    {
        var optionsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Integrify");
        var path = Path.Combine(optionsDirectory, $"{integrationArea.ToLower()}.integration.json");

        await using var openStream = File.OpenRead(path);

        var options = await JsonSerializer.DeserializeAsync<IntegrationOptions>(openStream);

        return options ?? throw new InvalidCastException();
    }

    public async Task UpdateIntegrationOptionsAsync(string integrationArea, IntegrationOptions options)
    {
        var optionsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Integrify");
        var path = Path.Combine(optionsDirectory, $"{integrationArea.ToLower()}.integration.json");
        
        await using var openWrite = File.OpenWrite(path);
        await JsonSerializer.SerializeAsync(openWrite, options);
    }
}