using Integrify.Modules.Synchronizer.Core.Events.Customers.External;
using Integrify.Shared.Abstractions.Contracts;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Modules.Synchronizer.Core.Contracts;

[Message("customers")]
internal class CustomersSynchronizationContract: Contract<CustomersSynchronizationRequested>
{
    public CustomersSynchronizationContract()
    {
        RequireAll();
    }
}