using System.Diagnostics.Metrics;

namespace HelloApi;

public static class CounterMetric
{
    public static Counter<int> Counter { get; set; } = null!;
}
