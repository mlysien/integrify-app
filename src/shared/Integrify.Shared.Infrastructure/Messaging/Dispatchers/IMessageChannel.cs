using System.Threading.Channels;
using Inflow.Shared.Infrastructure.Messaging.Dispatchers;

namespace Integrify.Shared.Infrastructure.Messaging.Dispatchers;

internal interface IMessageChannel
{
    ChannelReader<MessageEnvelope> Reader { get; }
    ChannelWriter<MessageEnvelope> Writer { get; }
}