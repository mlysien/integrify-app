using Integrify.Clients.Worker.Service;
using Integrify.Clients.Worker.Service.Scoped;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddConsoleLogging();
builder.Services.AddIntegrations("Integrify.Integrations.");
builder.Services.AddHostedService<Worker>();
builder.Services.AddScoped<IScopedProcessingService, DefaultScopedProcessingService>();
var host = builder.Build();
host.Run();