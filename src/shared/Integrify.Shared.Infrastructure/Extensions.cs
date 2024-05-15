using System.Reflection;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Infrastructure.Commands;
using Integrify.Shared.Infrastructure.Contexts;
using Integrify.Shared.Infrastructure.Contracts;
using Integrify.Shared.Infrastructure.Controllers;
using Integrify.Shared.Infrastructure.Dispatchers;
using Integrify.Shared.Infrastructure.Events;
using Integrify.Shared.Infrastructure.Messaging;
using Integrify.Shared.Infrastructure.Modules;
using Integrify.Shared.Infrastructure.Queries;
using Integrify.Shared.Infrastructure.Serialization;
using Integrify.Shared.Infrastructure.Time;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Integrify.Shared.Infrastructure;

public static class Extensions
{
    private const string ApiName = "Integrify API";
    private const string ApiVersion = "v1";
    private const string CorrelationIdKey = "correlation-id";
    
    public static IServiceCollection AddInitializer<T>(this IServiceCollection services) where T : class, IInitializer
        => services.AddTransient<IInitializer, T>();
        
    public static void AddModularInfrastructure(this IServiceCollection services,
        IList<Assembly> assemblies, IList<IModule> modules) 
    {
        var disabledModules = new List<string>();
        using (var serviceProvider = services.BuildServiceProvider())
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            foreach (var (key, value) in configuration.AsEnumerable())
            {
                if (!key.Contains(":module:enabled"))
                {
                    continue;
                }

                if (!bool.Parse(value ?? throw new InvalidOperationException()))
                {
                    disabledModules.Add(key.Split(":")[0]);
                }
            }
        }

        // todo services.AddCorsPolicy();
        services.AddSwaggerGen(swagger =>
        {
            swagger.EnableAnnotations();
            swagger.CustomSchemaIds(x => x.FullName);
            swagger.SwaggerDoc(ApiVersion, new OpenApiInfo
            {
                Title = ApiName,
                Version = ApiVersion
            });
        });

        var appOptions = services.GetOptions<AppOptions>("app");
        services.AddSingleton(appOptions);

        services.AddMemoryCache();
        services.AddHttpClient();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddSerialization();
        services.AddModuleInfo(modules);
        services.AddModuleRequests(assemblies);
        // todo services.AddAuth(modules);
        // todo services.AddErrorHandling();
        services.AddContext();
        services.AddCommands(assemblies);
        services.AddQueries(assemblies);
        services.AddEvents(assemblies);
        // todo services.AddDomainEvents(assemblies);
        services.AddMessaging();
        // todo services.AddSecurity();
        services.AddClocks();
        services.AddDispatchers();
        // services.AddLoggingDecorators();
        // services.AddPostgres();
        // services.AddOutbox();
        // services.AddHostedService<DbContextAppInitializer>();
        services.AddContracts();
        services.AddControllers()
            .ConfigureApplicationPartManager(manager =>
            {
                var removedParts = new List<ApplicationPart>();
                foreach (var disabledModule in disabledModules)
                {
                    var parts = manager.ApplicationParts.Where(x => x.Name.Contains(disabledModule,
                        StringComparison.InvariantCultureIgnoreCase));
                    removedParts.AddRange(parts);
                }

                foreach (var part in removedParts)
                {
                    manager.ApplicationParts.Remove(part);
                }
                    
                manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
            });
    }

    public static IApplicationBuilder UseModularInfrastructure(this IApplicationBuilder app)
    {
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.All
        });
        app.UseCors("cors");
        app.UseCorrelationId();
        // app.UseErrorHandling();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{ApiVersion}/swagger.json", ApiName));
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl($"/swagger/{ApiVersion}/swagger.json");
            reDoc.DocumentTitle = ApiName;
        });
        app.UseContext();
        // app.UseLogging();
        app.UseRouting();
        app.UseAuthorization();

        return app;
    }

    public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
    {
        using var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        return configuration.GetOptions<T>(sectionName);
    }

    public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : new()
    {
        var options = new T();
        configuration.GetSection(sectionName).Bind(options);
        return options;
    }

    public static string GetModuleName(this object value)
        => value?.GetType().GetModuleName() ?? string.Empty;

    public static string GetModuleName(this Type type, string namespacePart = "Modules", int splitIndex = 2)
    {
        if (type?.Namespace is null)
        {
            return string.Empty;
        }

        return type.Namespace.Contains(namespacePart)
            ? type.Namespace.Split(".")[splitIndex].ToLowerInvariant()
            : string.Empty;
    }
        
    public static void UseCorrelationId(this IApplicationBuilder app)
    {
        app.Use((ctx, next) =>
        {
            ctx.Items.Add(CorrelationIdKey, Guid.NewGuid());
            return next();
        });
    }

    public static Guid? TryGetCorrelationId(this HttpContext context)
        => context.Items.TryGetValue(CorrelationIdKey, out var id) ? (Guid) (id ?? throw new InvalidOperationException()) : null;
}