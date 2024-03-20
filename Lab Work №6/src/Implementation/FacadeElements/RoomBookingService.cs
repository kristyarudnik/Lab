using Lab4.Models;

namespace Lab4.Implementation.FacadeElements
{
    public class RoomBookingService
    {
        public void BookRoom(BaseRoom room)
        {
            room.IsAvailable = false;
            Console.WriteLine($"Room {room.Id} is booked");
        }
    }
}
