using Microsoft.EntityFrameworkCore;

namespace backend.api;

public class SqliteTodoContext : BaseTodoContext
{
    public SqliteTodoContext(DbContextOptions options) : base(options)
    {
    }
}