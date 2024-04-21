using Integrify.Modules.Customers.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Modules.Customers.Core.Commands.Handlers;

internal class SynchronizeCustomersHandler(IMessageBroker messageBroker) : ICommandHandler<SynchronizeCustomers>
{
    public async Task HandleAsync(SynchronizeCustomers command, CancellationToken cancellationToken = default)
    { 
        await messageBroker.PublishAsync(new CustomersSynchronizationRequested(), cancellationToken);
    }
}