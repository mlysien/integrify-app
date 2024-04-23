using Integrify.Shared.Abstractions.Events;
using Plugins.Inbounds.Example.Port.Api;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler(
    IInboundCustomersApi customersApi): IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event, CancellationToken cancellationToken = default)
    {
        var customersCollection = await customersApi.GetCustomersCollectionAsync();
    }
}