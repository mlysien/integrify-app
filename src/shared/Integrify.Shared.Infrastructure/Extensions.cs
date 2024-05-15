using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Integrify.Shared.Infrastructure;

public static class Extensions
{
    private const string ApiName = "Integrify API";
    private const string ApiVersion = "v1";
    
    public static void AddInfrastructureLayer(this IServiceCollection services) 
    {
        services.AddControllers();
        services.AddHttpClient();
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
    }

    public static void UseInfrastructureLayer(this IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{ApiVersion}/swagger.json", ApiName));
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl($"/swagger/{ApiVersion}/swagger.json");
            reDoc.DocumentTitle = ApiName;
        });
    }
}