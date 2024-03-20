using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Observers
{
    public class RatingUpdate : IObserver
    {
        public void Update(BaseRoom room)
        {
            Console.WriteLine($"Rating update: Room rating is now {room.Rating}.");
        }
    }
}
