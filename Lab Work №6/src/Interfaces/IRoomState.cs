using Lab4.Models;

namespace Lab4.Interfaces
{
    public interface IRoomState
    {
        void BookRoom(RoomWithState room);
        void CheckIn(RoomWithState room);
        void CheckOut(RoomWithState room);
    }

}
