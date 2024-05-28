using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;
using Integrify.Clients.Cli.Interpreter.Commands.Executors;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Clients.Cli.Interpreter.Commands;


public static class Extensions
{
    public static void AddCommands(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IInfoCommand, InfoCommandExecutor>();
        serviceCollection.AddScoped<ISyncCommand, SyncCommandExecutor>();
    }
}