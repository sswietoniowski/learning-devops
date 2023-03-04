using Serilog;
using Serilog.Events;

using workerservice;

var name = typeof(Program).Assembly.GetName().Name;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithProperty("Assembly", name)
    .WriteTo.Seq("http://seq:5341")
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting host");
    IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddHostedService<Worker>();
        })
        .UseSerilog()
        .Build();

    IConfiguration configuration = host.Services.GetRequiredService<IConfiguration>();

    var debugView = (configuration as IConfigurationRoot).GetDebugView();

    Log.ForContext("DebugView", debugView)
        .Information("Configuration dump");

    Log.Information("Starting worker");

    var simpleProperty = configuration.GetValue<string>("SimpleProperty");

    Log.ForContext("SimpleProperty", simpleProperty)
        .Information("Loaded configuration!");

    host.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}