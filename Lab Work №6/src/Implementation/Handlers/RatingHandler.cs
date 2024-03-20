using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Handlers
{
    public class RatingHandler : Handler
    {
        public override void HandleRequest(BaseRoom room)
        {
            if (room.Rating is not null)
            {
                Console.WriteLine($"Room {room.Id} is already rated.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(room);
            }
        }
    }
}
