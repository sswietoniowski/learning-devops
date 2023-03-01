using AutoMapper;

using Microsoft.EntityFrameworkCore;

namespace backend.api;

public class TodoService : ITodoService
{
    private readonly BaseTodoContext _todoContext;
    private readonly IMapper _mapper;
    private readonly ILogger<TodoService> _logger;

    public TodoService(BaseTodoContext todoContext, IMapper mapper, ILogger<TodoService> logger)
    {
        _todoContext = todoContext;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<TodoDto> CreateTodoAsync(TodoForCreationDto todoForCreation)
    {
        var todo = _mapper.Map<TodoForCreationDto, Todo>(todoForCreation);

        await _todoContext.Todos.AddAsync(todo);
        await _todoContext.SaveChangesAsync();

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<TodoDto?> GetTodoAsync(int id)
    {
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            return null;
        }

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<IEnumerable<TodoDto>> GetTodosAsync()
    {
        var todos = await _todoContext.Todos.ToListAsync();

        return _mapper.Map<IEnumerable<Todo>, IEnumerable<TodoDto>>(todos);
    }

    public async Task<TodoDto?> UpdateTodoAsync(int id, TodoForUpdateDto todoForUpdate)
    {
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            return null;
        }

        _mapper.Map(todoForUpdate, todo);
        
        await _todoContext.SaveChangesAsync();

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<bool> DeleteTodoAsync(int id)
    {
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            return false;
        }

        _todoContext.Todos.Remove(todo);
        await _todoContext.SaveChangesAsync();

        return true;
    }
}