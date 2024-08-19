using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace NameApi;

public static class OTel
{
    private const string ServiceName = "NameApi";

    public static void ConfigureOpenTelemetry(this IServiceCollection services, string env)
    {
        var resourceBuilder = ResourceBuilder.CreateDefault()
            .AddService(ServiceName)
            .AddTelemetrySdk()
            .AddAttributes(new Dictionary<string, object>
            {
                ["host.name"] = Environment.MachineName,
                ["os.description"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                ["deployment.environment"] = env,
            });

        services.AddOpenTelemetry()
            .WithMetrics(builder =>
            {
                builder
                    .SetResourceBuilder(resourceBuilder)
                    .AddAspNetCoreInstrumentation()
                    .AddOtlpExporter(opt =>
                    {
                        opt.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
                        opt.Endpoint = new Uri("http://my-collector-collector.telemetry.svc.cluster.local:4317");
                    });
            })
            .WithTracing(builder =>
            {
                builder
                    .SetResourceBuilder(resourceBuilder)
                    .AddAspNetCoreInstrumentation()
                    .AddOtlpExporter(opt =>
                    {
                        opt.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
                        opt.Endpoint = new Uri("http://my-collector-collector.telemetry.svc.cluster.local:4317");
                    });
            });

        services.AddLogging(loggingBuilder => {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddJsonConsole();
            loggingBuilder.AddOpenTelemetry(logOpt => {
                logOpt
                    .SetResourceBuilder(resourceBuilder)
                    .AddOtlpExporter(opt => {
                        opt.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
                        opt.Endpoint = new Uri("http://my-collector-collector.telemetry.svc.cluster.local:4317");
                    });
            });
        });
    }
}