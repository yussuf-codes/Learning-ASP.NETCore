namespace Project002.BasicCRUD.Models;

public class ToDo
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required bool IsDone { get; set; }
}
