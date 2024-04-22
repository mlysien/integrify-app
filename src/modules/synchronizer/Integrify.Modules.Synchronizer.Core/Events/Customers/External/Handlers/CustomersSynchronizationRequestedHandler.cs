using Integrify.Shared.Abstractions.Events;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler : IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event, CancellationToken cancellationToken = default)
    {
        // todo time to touch Plugin for synchronize Customers
    }
}