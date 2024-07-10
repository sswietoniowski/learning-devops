using System.Data.SqlClient;
using Dapper;
using DockerCourseApi;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.Configure<Settings>(builder.Configuration);

var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin());

app.MapGet("/podcasts", async (IOptions<Settings> settings) =>
{
    var db = new SqlConnection(settings.Value.ConnectionString);

    return (await db.QueryAsync<Podcast>("SELECT * FROM Podcasts")).Select(x => x.Title);

    // return new List<string>
    // {
    //     "Unhandled Exception Podcast",
    //     "Developer Weekly Podcast",
    //     "The Stack Overflow Podcast",
    //     "The Hanselminutes Podcast",
    //     "The .NET Rocks Podcast",
    //     "The Azure Podcast",
    //     "The AWS Podcast",
    //     "The Rabbit Hole Podcast",
    //     "The .NET Core Podcast",
    // };
});

app.Run();

record Podcast(Guid Id, string Title);

public partial class Program
{
}
