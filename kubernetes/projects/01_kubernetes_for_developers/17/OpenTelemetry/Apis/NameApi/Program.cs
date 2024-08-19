using NameApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureOpenTelemetry(builder.Environment.EnvironmentName.ToLowerInvariant());

var app = builder.Build();

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Name API endpoint has been called!");
    return Results.Ok("Dan");
});

app.Run();
