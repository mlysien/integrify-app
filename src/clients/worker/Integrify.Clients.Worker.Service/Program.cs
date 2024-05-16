using Integrify.Clients.Worker.Service;
using Integrify.Clients.Worker.Service.Scoped;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;

const string integrationAssemblyPrefix = "Integrify.Integrations."; 

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddConsoleLogging();
builder.Services.AddIntegrations(integrationAssemblyPrefix);
builder.Services.AddHostedService<Worker>();
builder.Services.AddScoped<IScopedProcessingService, DefaultScopedProcessingService>();
var host = builder.Build();
host.Run();