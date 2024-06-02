using Integrify.Shared.Abstractions.Time;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Time;

public static class Extensions
{
    public static void AddClock(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IClock, Clock>();
    }
}