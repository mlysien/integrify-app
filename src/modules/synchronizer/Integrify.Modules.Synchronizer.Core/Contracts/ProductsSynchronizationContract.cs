using Integrify.Modules.Synchronizer.Core.Events.Products.External;
using Integrify.Shared.Abstractions.Contracts;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Modules.Synchronizer.Core.Contracts;

[Message("products")]
internal class ProductsSynchronizationContract: Contract<ProductsSynchronizationRequested>
{
    public ProductsSynchronizationContract()
    {
        RequireAll();
    }
}