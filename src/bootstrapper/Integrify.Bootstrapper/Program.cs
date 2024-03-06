using Integrify.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSharedFramework(builder.Configuration);

var app = builder.Build();
PrintBanner();

app.UseSharedFramework();
app.Run();
return;

void PrintBanner()
{
    Console.WriteLine("""

                      ██╗  ███╗   ██╗ ████████╗ ███████╗   ██████╗   ██████╗   ██╗  ███████╗ ██╗   ██╗
                      ██║  ████╗  ██║ ╚══██╔══╝ ██╔════╝  ██╔════╝   ██╔══██╗  ██║  ██╔════╝ ╚██╗ ██╔╝
                      ██║  ██╔██╗ ██║    ██║    █████╗    ██║  ███╗  ██████╔╝  ██║  █████╗    ╚████╔╝
                      ██║  ██║╚██╗██║    ██║    ██╔══╝    ██║   ██║  ██╔══██╗  ██║  ██╔══╝     ╚██╔╝
                      ██║  ██║ ╚████║    ██║    ███████╗  ╚██████╔╝  ██║  ██║  ██║  ██║         ██║
                      ╚═╝  ╚═╝  ╚═══╝    ╚═╝    ╚══════╝   ╚═════╝   ╚═╝  ╚═╝  ╚═╝  ╚═╝         ╚═╝

                      """);
}