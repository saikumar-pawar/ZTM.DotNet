using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDirectoryBrowser();

var app = builder.Build();

var fileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.WebRootPath, "images"));
var requestPath = "/public";

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = fileProvider,
    RequestPath = requestPath
});

app.UseDirectoryBrowser(
    new DirectoryBrowserOptions
    {
        FileProvider = fileProvider,
        RequestPath = requestPath
    }
    );

app.MapGet("/", () => "Hello World!");

app.Run();
