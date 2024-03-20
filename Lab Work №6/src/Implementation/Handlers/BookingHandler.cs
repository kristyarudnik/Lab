using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Handlers
{
    public class BookingHandler : Handler
    {
        public override void HandleRequest(BaseRoom room)
        {
            if (!room.IsAvailable)
            {
                Console.WriteLine($"Room {room.Id} is already booked.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(room);
            }
        }
    }

}
