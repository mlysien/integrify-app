using Integrify.Clients.Worker.Service;
using Integrify.Clients.Worker.Service.Scoped;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;
using Integrify.Shared.Infrastructure.Plugins;

const string integrationAssemblyPrefix = "Integrify.Integrations."; 
const string pluginAssemblyPrefix = "Integrify.Plugins."; 
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddConsoleLogging();
builder.Services.AddIntegrations(integrationAssemblyPrefix);
builder.Services.AddPlugins(pluginAssemblyPrefix);
builder.Services.AddHostedService<Worker>();
builder.Services.AddScoped<IScopedProcessingService, DefaultScopedProcessingService>();
var host = builder.Build();
host.Run();