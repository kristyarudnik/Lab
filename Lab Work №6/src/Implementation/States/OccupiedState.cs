using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.States
{
    public class OccupiedState : IRoomState
    {
        public void BookRoom(RoomWithState room)
        {
            Console.WriteLine("Cannot book an occupied room.");
        }

        public void CheckIn(RoomWithState room)
        {
            Console.WriteLine("Cannot check in an occupied room.");
        }

        public void CheckOut(RoomWithState room)
        {
            room.SetState(new AvailableState());
            Console.WriteLine("Room is now available.");
        }
    }
}
