namespace MutiTenancy.Entities;

public class TodoItem
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
    public int TenantId { get; set; }
}