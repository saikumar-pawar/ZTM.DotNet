using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (IConfiguration config) => 
$"Welcome to {config["Application:Customer"]}'s {config["Application:Name"]}!");

app.MapGet("/welcome", (IConfiguration configuration) =>
{
    var config = configuration.GetSection("Application").Get<Config>() ??
    throw new InvalidOperationException("Invalid app configuration");
    
    return $"Welcome to {config.Customer}'s {config.Name}!";
});

app.Run();

public record Config(string Name, string Customer);
