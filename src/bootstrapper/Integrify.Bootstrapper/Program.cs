using Integrify.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSharedFramework(builder.Configuration);

var app = builder.Build();
PrintBanner();

app.UseSharedFramework();
app.MapGet("/", () => "Integrify is running!");
app.Run();
return;

void PrintBanner()
{
    Console.WriteLine("""
                       _____ _   _ _______ ______ _____ _____  _____ ________     __
                      |_   _| \ | |__   __|  ____/ ____|  __ \|_   _|  ____\ \   / /
                        | | |  \| |  | |  | |__ | |  __| |__) | | | | |__   \ \_/ / 
                        | | | . ` |  | |  |  __|| | |_ |  _  /  | | |  __|   \   /  
                       _| |_| |\  |  | |  | |___| |__| | | \ \ _| |_| |       | |   
                      |_____|_| \_|  |_|  |______\_____|_|  \_\_____|_|       |_|   
                                                                                    
                      """);
}