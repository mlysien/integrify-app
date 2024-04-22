using Integrify.Modules.Synchronizer.Core.Events.External;
using Integrify.Shared.Abstractions.Contracts;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Modules.Synchronizer.Core.Contracts;

[Message("orders")]
internal class OrdersSynchronizationContract: Contract<OrdersSynchronizationRequested>
{
    public OrdersSynchronizationContract()
    {
        RequireAll();
    }
}