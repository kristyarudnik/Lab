using Lab4.Interfaces;

namespace Lab4.Implementation.Decorators
{
    public class BookingDecorator : RoomDecorator
    {
        public BookingDecorator(IRoom room) : base(room)
        {
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("- Bookable");
        }

        public void Book()
        {
            Console.WriteLine("Room booked successfully!");
        }
    }
}
