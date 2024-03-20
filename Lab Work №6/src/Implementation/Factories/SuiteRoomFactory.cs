using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Factories
{
    public class SuiteRoomFactory : IRoomFactory
    {
        public BaseRoom CreateRoom()
        {
            return new RoomSuite { IsAvailable = true, Location = "USA", Rating = 5.0  };
        }
    }
}
