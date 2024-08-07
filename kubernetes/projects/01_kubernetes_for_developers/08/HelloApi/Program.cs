using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.Configure<Config>(builder.Configuration);
var app = builder.Build();

app.MapGet("/", async (HttpClient httpClient, IOptions<Config> config) =>
{
    var name = await httpClient
        .GetStringAsync(config.Value.NameApiUri);

    return $"Hello {name.Trim('"')}";
});

app.Run();

internal class Config
{
    public string NameApiUri { get; init; } = null!;
}
