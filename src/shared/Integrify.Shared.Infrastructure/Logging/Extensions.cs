using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Integrify.Shared.Infrastructure.Logging;

public static class Extensions
{
    private const string ConsoleOutputTemplate = "{Timestamp:HH:mm:ss} [{Level:u3}] {Message}{NewLine}{Exception}";

    public static void AddConsoleLogging(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSerilog(lc => lc
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console(outputTemplate: ConsoleOutputTemplate));
    }
}