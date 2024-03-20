using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.States
{
    public class AvailableState : IRoomState
    {
        public void BookRoom(RoomWithState room)
        {
            room.SetState(new BookedState());
            Console.WriteLine("Room is now booked.");
        }

        public void CheckIn(RoomWithState room)
        {
            Console.WriteLine("Cannot check in an available room.");
        }

        public void CheckOut(RoomWithState room)
        {
            Console.WriteLine("Cannot check out an available room.");
        }
    }
}
