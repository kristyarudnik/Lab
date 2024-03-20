using Lab4.Interfaces;

namespace Lab4.Models
{
    public class BaseRoom : IRoom
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
        public double? Rating { get; set; }

        public void Display()
        {
            Console.WriteLine("Base Room");
        }
    }
}
