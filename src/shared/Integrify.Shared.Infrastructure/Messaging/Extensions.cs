using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Messaging;

internal static class Extensions
{
    public static IServiceCollection AddMessaging(this IServiceCollection services)
    {
        services.AddTransient<IMessageBroker, DefaultMessageBroker>();
        services.AddTransient<IAsyncEventPublisher, AsyncEventPublisher>();
        services.AddSingleton<IEventChannel, EventChannel>();
        services.AddHostedService<EventPublisherJob>();
            
        return services;
    }
}