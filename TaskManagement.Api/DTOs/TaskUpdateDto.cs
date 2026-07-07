namespace TaskManagement.Api.DTOs;

public class TaskUpdateDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Status { get; set; } = "Yapilacak";
    public DateTime? DueDate { get; set; }
    public int CategoryId { get; set; }
}