using Integrify.Shared.Abstractions.Events;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Events;

internal sealed class EventPublisher(IServiceProvider serviceProvider) : IEventPublisher
{
    public async Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : class, IEvent
    {
        using var scope = serviceProvider.CreateScope();
        var handlers = scope.ServiceProvider.GetServices<IEventHandler<TEvent>>();
        var tasks = handlers.Select(x => x.HandleAsync(@event, cancellationToken));
        await Task.WhenAll(tasks);
    }
}