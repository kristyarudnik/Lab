using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Observers
{
    public class BookingNotification : IObserver
    {
        public void Update(BaseRoom room)
        {
            if (!room.IsAvailable)
            {
                Console.WriteLine("Booking notification: Room is booked.");
            }
        }
    }
}
