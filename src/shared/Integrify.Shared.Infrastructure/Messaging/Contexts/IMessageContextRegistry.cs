using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}