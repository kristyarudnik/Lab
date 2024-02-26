namespace Lab4.Models;

public class Room
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Location { get; set; }
    public bool IsAvailable { get; set; }
    public double Rating { get; set; } // Предполагается, что у каждого номера изначально есть оценка
}
