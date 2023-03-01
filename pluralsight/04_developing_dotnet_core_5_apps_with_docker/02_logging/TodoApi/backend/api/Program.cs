using Polly;
using backend.api;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var databaseEngine = builder.Configuration.GetValue<DatabaseEngine>("DatabaseEngine");

if (databaseEngine == DatabaseEngine.Sqlite)
{
    builder.Services.AddDbContext<SqliteTodoContext>(options =>
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"));
    });
    builder.Services.AddScoped<BaseTodoContext>(provider => provider.GetRequiredService<SqliteTodoContext>());
}
else if (databaseEngine == DatabaseEngine.Mssql)
{
    builder.Services.AddDbContext<MssqlTodoContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("MssqlConnection"));
    });
    builder.Services.AddScoped<BaseTodoContext>(provider => provider.GetRequiredService<MssqlTodoContext>());
}
else 
{
    throw new InvalidOperationException("Invalid database engine");
}

builder.Services.AddAutoMapper(typeof(TodoProfile));
builder.Services.AddScoped<ITodoService, TodoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// TODO: add support for https
// app.UseHttpsRedirection();

app.MapGet("/api/todos", async (ITodoService todoService) =>
{
    var todos = await todoService.GetTodosAsync();

    return Results.Ok(todos);
})
    .WithName("GetTodos")
    .Produces<IEnumerable<TodoDto>>(StatusCodes.Status200OK);

// TODO: enable to show how easy is to change Docker image
// app.MapPost("/api/todos", async (ITodoService todoService, TodoForCreationDto todoDto) =>
// {
//     var todo = await todoService.CreateTodoAsync(todoDto);

//     return Results.Created($"/api/todos/{todo.Id}", todo);
// })
//     .WithName("CreateTodo")
//     .Produces<TodoDto>(StatusCodes.Status201Created)
//     .ProducesValidationProblem() // Validation errors, not yet implemented
//     .ProducesProblem(StatusCodes.Status500InternalServerError);

const int MAX_RETRIES = 7;
const int RETRY_DELAY_IN_SECONDS = 15;
var retryPolicy = Policy.Handle<Exception>()
	.WaitAndRetryAsync(retryCount: MAX_RETRIES, 
        sleepDurationProvider: (attemptCount) => TimeSpan.FromSeconds(RETRY_DELAY_IN_SECONDS));

await retryPolicy.ExecuteAsync(async () =>
{
    var context = (app as IApplicationBuilder)
        ?.ApplicationServices
        .CreateScope().ServiceProvider
        .GetRequiredService<BaseTodoContext>() 
        ?? throw new InvalidOperationException("Invalid application builder");

    if ((await context.Database.GetPendingMigrationsAsync()).Any())
    {
        await context.Database.MigrateAsync();
    }
});

app.Run();
