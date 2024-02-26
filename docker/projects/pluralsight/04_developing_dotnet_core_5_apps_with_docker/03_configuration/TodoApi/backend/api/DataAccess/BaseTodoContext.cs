using Microsoft.EntityFrameworkCore;

namespace backend.api;

public abstract class BaseTodoContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    public BaseTodoContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Todo>().HasData(
            new Todo { Id = 1, Title = "Todo 1", Description = "Todo 1 Description", IsCompleted = false },
            new Todo { Id = 2, Title = "Todo 2", Description = "Todo 2 Description", IsCompleted = true },
            new Todo { Id = 3, Title = "Todo 3", Description = "Todo 3 Description", IsCompleted = false }
        );
    }
}