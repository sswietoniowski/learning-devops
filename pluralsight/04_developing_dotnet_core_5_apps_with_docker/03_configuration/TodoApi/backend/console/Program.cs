using Microsoft.Extensions.Configuration;
using Serilog;

namespace console;

class Program
{
    private static IConfiguration _configuration;

    static void Main(string[] args)
    {
        //http://bit.ly/default-builder-source
        // csproj for nuget packages
        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
            .AddJsonFile("appsettings.json", false)
            .AddEnvironmentVariables()
            .Build();

        ConfigureLogging();

        try
        {
            //var connectionString = "hello"; //ConnectionStrings:Db
            var connectionString = _configuration.GetConnectionString("Db");

            //var simpleProperty = "hey";     // SimpleProperty
            var simpleProperty = _configuration.GetValue<string>("SimpleProperty");
            //var nestedProp = "here we go";  // Inventory->NestedProperty
            var nestedProp = _configuration.GetValue<string>("Inventory:NestedProperty");

            Log.ForContext("ConnectionString", connectionString)
                .ForContext("SimpleProperty", simpleProperty)
                .ForContext("Inventory:NestedProperty", nestedProp)
                .Information("Loaded configuration!", connectionString);

            Log.ForContext("Args", args)
               .Information("Starting program...");

            Console.WriteLine("Hello World!"); // do some invoice generation

            Log.Information("Finished execution!");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Some kind of exception occurred.");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    private static void ConfigureLogging()
    {
        var name = typeof(Program).Assembly.GetName().Name;

        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .Enrich.WithMachineName()
            .Enrich.WithProperty("Assembly", name)
            .WriteTo.Console()
            .WriteTo.Seq("http://seq:5341")
            .CreateLogger();
    }
}