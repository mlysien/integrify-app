using Integrify.Shared.Abstractions.Contexts;

namespace Integrify.Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}