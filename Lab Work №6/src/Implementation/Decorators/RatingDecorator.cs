using Lab4.Interfaces;

namespace Lab4.Implementation.Decorators
{
    public class RatingDecorator : RoomDecorator
    {
        public RatingDecorator(IRoom room) : base(room)
        {
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("- Rating");
        }

        public void Rate(int rating)
        {
            Console.WriteLine($"Room rated with {rating} stars.");
        }
    }
}
