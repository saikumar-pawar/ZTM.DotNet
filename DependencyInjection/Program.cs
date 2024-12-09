var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGreetings, Greetings>();

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