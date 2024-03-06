using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared;

public static class Extensions
{
    public static IServiceCollection AddSharedFramework(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
        
    public static IApplicationBuilder UseSharedFramework(this IApplicationBuilder app)
    {
        return app;
    }
}