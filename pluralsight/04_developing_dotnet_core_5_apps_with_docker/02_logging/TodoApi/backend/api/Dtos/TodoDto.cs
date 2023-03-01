using System.ComponentModel.DataAnnotations;

namespace backend.api;

public class TodoDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}

public class TodoForCreationDto
{
    [Required]
    [MaxLength(128)]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class TodoForUpdateDto : TodoForCreationDto
{
    [Required]
    public bool IsCompleted { get; set; }
}