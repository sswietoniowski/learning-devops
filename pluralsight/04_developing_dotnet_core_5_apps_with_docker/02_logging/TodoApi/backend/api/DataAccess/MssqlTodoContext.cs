using Microsoft.EntityFrameworkCore;

namespace backend.api;

public class MssqlTodoContext : BaseTodoContext
{
    public MssqlTodoContext(DbContextOptions options) : base(options)
    {
    }
}