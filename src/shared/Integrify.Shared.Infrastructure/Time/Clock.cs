using Integrify.Shared.Abstractions.Time;

namespace Integrify.Shared.Infrastructure.Time;

public class Clock : IClock
{
    public long NowTicks()
    {
        return DateTime.UtcNow.Ticks;
    }
}