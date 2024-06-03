using Integrify.Clients.Cli.Interpreter;
using Integrify.Clients.Cli.Service;
using Integrify.Clients.Cli.Service.Services;
using Integrify.Shared.Infrastructure;

const string integrationAssemblyPrefix = "Integrify.Integrations."; 
const string pluginAssemblyPrefix = "Integrify.Plugins."; 
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddInfrastructure(integrationAssemblyPrefix, pluginAssemblyPrefix);
builder.Services.AddCommandsInterpreter();
builder.Services.AddHostedService<Worker>();
builder.Services.AddScoped<IProcessingService, ProcessingService>();
var host = builder.Build();
host.Run();