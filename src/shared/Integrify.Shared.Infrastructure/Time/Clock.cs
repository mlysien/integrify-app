using Integrify.Shared.Abstractions.Time;

namespace Integrify.Shared.Infrastructure.Time;

public class Clock : IClock
{
    public long CurrentTimeTicks()
    {
        return DateTime.UtcNow.Ticks;
    }
}