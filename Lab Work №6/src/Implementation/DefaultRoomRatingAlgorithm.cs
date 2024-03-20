using Lab4.Interfaces;

namespace Lab4.Implementation
{
    public class DefaultRoomRatingAlgorithm : RoomRatingAlgorithm
    {
        protected override double CalculateRating()
        {
            var rand = new Random();
            return rand.NextDouble() * 10;
        }
    }
}
