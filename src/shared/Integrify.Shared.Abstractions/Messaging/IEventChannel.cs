using System.Threading.Channels;
using Integrify.Shared.Abstractions.Events;

namespace Integrify.Shared.Abstractions.Messaging;

public interface IEventChannel
{
    ChannelReader<IEvent> Reader { get; }
    ChannelWriter<IEvent> Writer { get; }
}