using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace Integrify.Shared.Infrastructure.Logging;

public static class Extensions
{
    private const string ConsoleOutputTemplate = "{Timestamp:HH:mm:ss} [{Level:u3}] {Message}{NewLine}{Exception}";

    public static void UseLogging(this IHostBuilder builder)
    {
        builder.UseSerilog((_, loggerConfiguration) =>
            loggerConfiguration.WriteTo.Console(LogEventLevel.Information, ConsoleOutputTemplate));
    }
}