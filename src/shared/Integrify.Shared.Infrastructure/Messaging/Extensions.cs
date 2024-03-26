using Inflow.Shared.Infrastructure.Messaging.Dispatchers;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Infrastructure.Messaging.Brokers;
using Integrify.Shared.Infrastructure.Messaging.Contexts;
using Integrify.Shared.Infrastructure.Messaging.Dispatchers;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Messaging;

public static class Extensions
{
    private const string SectionName = "messaging";
        
    public static IServiceCollection AddMessaging(this IServiceCollection services)
    {
        services.AddTransient<IMessageBroker, InMemoryMessageBroker>();
        services.AddTransient<IAsyncMessageDispatcher, AsyncMessageDispatcher>();
        services.AddSingleton<IMessageChannel, MessageChannel>();
        services.AddSingleton<IMessageContextProvider, MessageContextProvider>();
        services.AddSingleton<IMessageContextRegistry, MessageContextRegistry>();

        var messagingOptions = services.GetOptions<MessagingOptions>(SectionName);
        services.AddSingleton(messagingOptions);

        if (messagingOptions.UseAsyncDispatcher)
        {
            services.AddHostedService<AsyncDispatcherJob>();
        }
            
        return services;
    }
}