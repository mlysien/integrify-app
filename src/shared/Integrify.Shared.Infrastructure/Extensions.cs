using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Infrastructure.Time;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Integrify.Shared.Infrastructure;

public static class Extensions
{
    private const string ApiTitle = "Integrify API";
    private const string ApiVersion = "v1";
    
    public static IServiceCollection AddInitializer<T>(this IServiceCollection services) where T : class, IInitializer
        => services.AddTransient<IInitializer, T>();
        
    public static IServiceCollection AddModularInfrastructure(this IServiceCollection services) 
    {
        var disabledModules = new List<string>();
        if (disabledModules == null) throw new ArgumentNullException(nameof(disabledModules));
        using (var serviceProvider = services.BuildServiceProvider())
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            foreach (var (key, value) in configuration.AsEnumerable())
            {
                if (!key.Contains(":module:enabled"))
                {
                    continue;
                }

                if (value != null && !bool.Parse(value))
                {
                    disabledModules.Add(key.Split(":")[0]);
                }
            }
        }
        
        services.AddEndpointsApiExplorer();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddSingleton<IClock, UtcTime>();
        
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