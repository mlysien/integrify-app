using Integrify.Clients.Cli.Interpreter;
using Integrify.Clients.Cli.Service;
using Integrify.Clients.Cli.Service.Services;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;
using Integrify.Shared.Infrastructure.Plugins;

const string integrationAssemblyPrefix = "Integrify.Integrations."; 
const string pluginAssemblyPrefix = "Integrify.Plugins."; 
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddConsoleLogging();
builder.Services.AddIntegrations(integrationAssemblyPrefix);
builder.Services.AddPlugins(pluginAssemblyPrefix);
builder.Services.AddCommandsInterpreter();
builder.Services.AddHostedService<Worker>();
builder.Services.AddScoped<IProcessingService, ProcessingService>();
var host = builder.Build();
host.Run();