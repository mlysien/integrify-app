using Integrify.Shared.Abstractions.Time;

namespace Integrify.Shared.Infrastructure.Time;

internal sealed class Clock : IClock
{
    public long NowTicks()
    {
        return DateTime.UtcNow.Ticks;
    }

    public DateTime NowDateTime()
    {
        return DateTime.UtcNow;
    }
}