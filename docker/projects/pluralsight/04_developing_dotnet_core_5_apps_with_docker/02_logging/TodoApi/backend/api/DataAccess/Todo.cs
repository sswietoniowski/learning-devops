using System.ComponentModel.DataAnnotations;

namespace backend.api;

public class Todo
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(128)]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    [Required]
    public bool IsCompleted { get; set; } = false;
}