var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
var app = builder.Build();

app.MapGet("/", async (HttpClient httpClient) =>
{
    var name = await httpClient
        .GetStringAsync("http://name-api.services-demo.svc.cluster.local");

    return $"Hello {name.Trim('"')}";
});

app.Run();
