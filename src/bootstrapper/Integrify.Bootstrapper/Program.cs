using Integrify.Shared.Infrastructure.Logging;
using Integrify.Shared.Infrastructure.Modules;

namespace Integrify.Bootstrapper;

public static class Program
{
    public static Task Main(string[] args)
        => CreateHostBuilder(args).Build().RunAsync();

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .ConfigureModules()
            .UseLogging();
}