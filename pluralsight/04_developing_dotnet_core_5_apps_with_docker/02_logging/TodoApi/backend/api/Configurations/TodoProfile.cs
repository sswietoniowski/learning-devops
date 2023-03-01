using AutoMapper;

namespace backend.api;

public class TodoProfile : Profile
{
    public TodoProfile()
    {
        CreateMap<Todo, TodoDto>().ReverseMap();
        CreateMap<TodoForCreationDto, Todo>();
        CreateMap<TodoForUpdateDto, Todo>();
    }
}