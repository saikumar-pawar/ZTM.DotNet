var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<IGreetings, Greetings>();

builder.Services.Addgreetings();

var app = builder.Build();

app.MapGet("/", (IGreetings greetings) => greetings.GetGreetings());

app.Run();

public interface IGreetings
{
    string GetGreetings();
}

public class Greetings : IGreetings
{
    public string GetGreetings()
    {
        return "Hello from a service!";
    }
}

public static class GreetingsServiceBuilderExtensions
{
    public static IServiceCollection Addgreetings(this IServiceCollection services)
    {
        services.AddScoped<IGreetings, Greetings>();
        return services;
    }
}