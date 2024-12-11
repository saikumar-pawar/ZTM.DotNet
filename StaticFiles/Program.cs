var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); //wwwroot

app.MapGet("/", () => "Hello World!");

app.Run();
