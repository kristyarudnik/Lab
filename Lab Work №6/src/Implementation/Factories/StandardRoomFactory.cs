using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Factories
{
    public class StandardRoomFactory : IRoomFactory
    {
        public BaseRoom CreateRoom()
        {
            return new RoomStandart { IsAvailable = true, Location = "USA_NY", Rating = 4.0 };
        }
    }
}
