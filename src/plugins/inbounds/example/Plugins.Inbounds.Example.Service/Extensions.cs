using Microsoft.Extensions.DependencyInjection;
using Plugins.Inbounds.Example.Service.Services;
using Plugins.Inbounds.Example.Service.Services.Abstractions;

namespace Plugins.Inbounds.Example.Service;

public static class Extensions
{
    public static void AddServicesLayer(this IServiceCollection services)
    {
        services.AddTransient<IRestApiService, RestApiService>();
    }
}