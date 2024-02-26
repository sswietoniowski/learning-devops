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
        _todoContext = todoContext ?? throw new ArgumentNullException(nameof(todoContext));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<TodoDto> CreateTodoAsync(TodoForCreationDto todoForCreation)
    {
        _logger.LogInformation("Creating todo with title {title}", todoForCreation.Title); // instead of using string interpolation we can use the logger's built-in support for structured logging

        var todo = _mapper.Map<TodoForCreationDto, Todo>(todoForCreation);        

        await _todoContext.Todos.AddAsync(todo);
        await _todoContext.SaveChangesAsync();

        _logger.LogInformation($"Todo with id {todo.Id} created");

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<TodoDto?> GetTodoAsync(int id)
    {
        _logger.LogInformation($"Getting todo with id {id}");
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            _logger.LogWarning($"Todo with id {id} not found");
            return null;
        }        

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<IEnumerable<TodoDto>> GetTodosAsync()
    {
        _logger.LogInformation("Getting all todos");
        var todos = await _todoContext.Todos.ToListAsync();

        return _mapper.Map<IEnumerable<Todo>, IEnumerable<TodoDto>>(todos);
    }

    public async Task<TodoDto?> UpdateTodoAsync(int id, TodoForUpdateDto todoForUpdate)
    {
        _logger.LogInformation($"Updating todo with id {id}");
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            _logger.LogWarning($"Todo with id {id} not found");
            return null;
        }

        _mapper.Map(todoForUpdate, todo);
        
        await _todoContext.SaveChangesAsync();

        _logger.LogInformation($"Todo with id {todo.Id} updated");

        return _mapper.Map<Todo, TodoDto>(todo);
    }

    public async Task<bool> DeleteTodoAsync(int id)
    {
        _logger.LogInformation($"Deleting todo with id {id}");
        var todo = await _todoContext.Todos.FindAsync(id);

        if (todo == null)
        {
            _logger.LogWarning($"Todo with id {id} not found");
            return false;
        }

        _todoContext.Todos.Remove(todo);
        await _todoContext.SaveChangesAsync();

        _logger.LogInformation($"Todo with id {todo.Id} deleted");

        return true;
    }
}