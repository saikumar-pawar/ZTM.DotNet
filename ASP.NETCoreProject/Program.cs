var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/", (IConfiguration config) => {
    var applicationConfig = config.GetSection("Application").Get<AppConfig>() ??
    throw new InvalidOperationException("Invalid app configuration");

    return $"Welcome to {applicationConfig.Customer}'s {applicationConfig.Name}!";
});

app.MapGet("/{name}", (string name) => $"Hello {name}!");
app.MapGet("/error", () => "Unfortunately, an error happened.");
app.MapGet("/health", () => "healthy");

app.UseHealthChecks("/health");
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}

app.Run();

public record AppConfig(string Name, string Customer);
