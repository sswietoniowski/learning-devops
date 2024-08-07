Console.WriteLine("Started JobDemoConsoleApp");

if (args.Length > 0 && args[0] == "simulateError")
    throw new Exception("Something bad has happened!");

var jobIndex = Environment.GetEnvironmentVariable("JOB_COMPLETION_INDEX");
if (jobIndex is not null)
    Console.WriteLine($"JOB_COMPLETION_INDEX is {jobIndex}");

Console.WriteLine("Waiting 10 seconds to simulate work being done...");
await Task.Delay(TimeSpan.FromSeconds(10));

Console.WriteLine("Finished JobDemoConsoleApp");
