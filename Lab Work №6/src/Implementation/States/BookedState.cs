using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.States
{
    public class BookedState : IRoomState
    {
        public void BookRoom(RoomWithState room)
        {
            Console.WriteLine("Room is already booked.");
        }

        public void CheckIn(RoomWithState room)
        {
            room.SetState(new OccupiedState());
            Console.WriteLine("Room is now occupied.");
        }

        public void CheckOut(RoomWithState room)
        {
            Console.WriteLine("Cannot check out a booked room.");
        }
    }
}
