var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// print app banner
PrintBanner();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
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