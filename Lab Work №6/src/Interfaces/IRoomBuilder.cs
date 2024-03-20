using Lab4.Models;

namespace Lab4.Interfaces
{
    public interface IRoomBuilder
    {
        public IRoomBuilder SetLocation(string location);
        public IRoomBuilder SetRating(double rating);
        public IRoomBuilder SetAvailability(bool isAvailable);
        public Room Build();
    }
}
