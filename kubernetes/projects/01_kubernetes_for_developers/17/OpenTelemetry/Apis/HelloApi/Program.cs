using HelloApi;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.Configure<Config>(builder.Configuration);
builder.Services.ConfigureOpenTelemetry(builder.Environment.EnvironmentName.ToLowerInvariant());
var app = builder.Build();

app.MapGet("/", async (HttpClient httpClient, IOptions<Config> config) =>
{
    app.Logger.LogInformation("Hello API endpoint has been called!");
    CounterMetric.Counter.Add(1);

    var name = await httpClient
        .GetStringAsync(config.Value.NameApiUri);

    return $"Hello {name.Trim('"')}";
});

app.Run();

namespace HelloApi
{
    internal class Config
    {
        public string NameApiUri { get; init; } = null!;
    }
}
