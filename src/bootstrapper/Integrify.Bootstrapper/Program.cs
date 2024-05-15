using Integrify.Bootstrapper;
using Integrify.Shared.Infrastructure;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;

const string integrationAssemblyPrefix = "Integrify.Integrations.";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructureLayer();
builder.Host.UseLogging();

var integrations = IntegrationLoader.LoadIntegrations(integrationAssemblyPrefix);

foreach (var integration in integrations)
{
    integration.AddIntegrationDependencies(builder.Services);
}

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILogger<Program>>();

logger.PrintBanner();
foreach (var integration in integrations)
{
    logger.LogInformation("{0} integration detected.", integration.Name);
}
app.UseInfrastructureLayer();
app.Run();
