using Lab4.Interfaces;

namespace Lab4.Implementation
{
    public class VipRoomRatingAlgorithm : RoomRatingAlgorithm
    {
        protected override double CalculateRating()
        {
            return 4.8;
        }

        protected override void DisplayRating(double rating)
        {
            Console.WriteLine($"VIP Room rated with {rating} stars.");
        }
    }
}
