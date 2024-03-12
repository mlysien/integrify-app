using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Commands;

public static class Extensions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
        
        return services;
    }
}