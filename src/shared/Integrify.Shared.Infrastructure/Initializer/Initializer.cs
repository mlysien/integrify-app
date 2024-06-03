using System.Text;
using Integrify.Shared.Abstractions.Initializer;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Initializer;

public class Initializer(
    ILogger<Initializer> logger,
    IList<IIntegrationArea> integrationAreas) 
    : IInitializer
{
    private readonly string _repositoryDir =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Integrify");
    
    
    
    public async Task InitIntegrationEnvironment()
    {
        if (!Directory.Exists(_repositoryDir))
        {
            logger.LogWarning("Integrify directory doesn't exist, creating...");
            Directory.CreateDirectory(_repositoryDir);
        }
        
        foreach (var integrationArea in integrationAreas)
        {
            var path = Path.Combine(_repositoryDir, $"{integrationArea.Name.ToLower()}.integration.config");

            await WriteAsync(path, "Ile lat?");
        }
    }
    
    private async Task WriteAsync(string path, string data)
    {
        var buffer = Encoding.UTF8.GetBytes(data);

        await using var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, buffer.Length, true);
        await fs.WriteAsync(buffer, 0, buffer.Length);
    }
}