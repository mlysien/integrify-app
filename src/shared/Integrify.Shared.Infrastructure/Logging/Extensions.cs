using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace Integrify.Shared.Infrastructure.Logging;

public static class Extensions
{
    private const string ConsoleOutputTemplate = "{Timestamp:HH:mm:ss} [{Level:u3}] {Message}{NewLine}{Exception}";
    private const string AppSectionName = "app";
    private const string LoggerSectionName = "logger";
    
    public static IHostBuilder UseLogging(this IHostBuilder builder, Action<LoggerConfiguration>? configure = null,
        string loggerSectionName = LoggerSectionName,
        string appSectionName = AppSectionName)
        => builder.UseSerilog((context, loggerConfiguration) =>
        {
            loggerConfiguration.WriteTo.Console(LogEventLevel.Information, ConsoleOutputTemplate);
        });

}