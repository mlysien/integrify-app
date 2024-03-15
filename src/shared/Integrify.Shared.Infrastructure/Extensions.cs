using System.Reflection;
using Integrify.Shared.Infrastructure.Commands;
using Integrify.Shared.Infrastructure.Events;
using Integrify.Shared.Infrastructure.Messaging;
using Integrify.Shared.Infrastructure.Queries;
using Integrify.Shared.Infrastructure.Time;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Integrify.Shared.Infrastructure;

public static class Extensions
{
    private const string ApiTitle = "Integrify API";
    private const string ApiVersion = "v1";
    
    public static IServiceCollection AddInitializer<T>(this IServiceCollection services) where T : class, IInitializer
        => services.AddTransient<IInitializer, T>();
        
    public static IServiceCollection AddModularInfrastructure(this IServiceCollection services, IList<Assembly> assemblies) 
    {
        services.AddEndpointsApiExplorer();
        services.AddMemoryCache();
        services.AddHttpClient();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddClocks();
        services.AddEvents(assemblies);
        services.AddCommands(assemblies);
        services.AddQueries(assemblies);
        services.AddMessaging();
        services.AddSwaggerGen(swagger =>
        {
            swagger.EnableAnnotations();
            swagger.CustomSchemaIds(x => x.FullName);
            swagger.SwaggerDoc(ApiVersion, new OpenApiInfo
            {
                Title = ApiTitle,
                Version = ApiVersion
            });
        });
            
        return services;
    }

    public static IApplicationBuilder UseModularInfrastructure(this IApplicationBuilder app)
    {
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.All
        });
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl("/swagger/v1/swagger.json");
            reDoc.DocumentTitle = "Modular API";
        });
        app.UseHttpsRedirection();
        app.UseRouting();
        
        return app;
    }
}