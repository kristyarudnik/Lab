using Lab4.Models;

namespace Lab4.Implementation.FacadeElements
{
    public class RoomRatingService
    {
        public double RateRoom(BaseRoom room, double rating)
        {
            room.Rating = rating;
            Console.WriteLine($"Set rating to room = {room.Type}");
            return room.Rating.Value;
        }
    }
}
