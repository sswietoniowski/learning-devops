var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var fakeLivenessFault = false;
var fakeReadinessFault = false;
var fakeStartupFault = false;

app.MapGet("/", () => $"Hello from {Environment.MachineName}!");

app.MapGet("/liveness", () => fakeLivenessFault ? Results.Problem() : Results.Ok());
app.MapGet("/readiness", () => fakeReadinessFault ? Results.Problem() : Results.Ok());
app.MapGet("/startup", () => fakeStartupFault ? Results.Problem() : Results.Ok());

app.MapPost("/faults", (Faults faults) =>
{
    fakeLivenessFault = faults.FakeLivenessFault;
    fakeReadinessFault = faults.FakeReadinessFault;
    fakeStartupFault = faults.FakeStartupFault;
});

app.Run();

internal record Faults(bool FakeLivenessFault, bool FakeReadinessFault, bool FakeStartupFault);
