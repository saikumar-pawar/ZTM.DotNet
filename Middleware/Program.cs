using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Use(async (context, next) =>
//{
    
//});

app.UseLogging();
app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", () => "Hello World!");

app.Run();

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Response.Headers.Append("my-header", "my-value");

        //change the HTTP response
        await _next(context);
        //do not change the HTTP response

        Console.WriteLine(context.Request.Path);
    }
}

public static class LoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseLogging(this IApplicationBuilder app)
    {
        return app.UseMiddleware<LoggingMiddleware>();
    }
}
