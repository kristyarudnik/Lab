using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class RoomBuilder : IRoomBuilder
    {
        private readonly Room _room;

        public RoomBuilder(string type)
        {
            _room = new Room { Type = type };
        }

        public IRoomBuilder SetLocation(string location)
        {
            _room.Location = location;
            return this;
        }

        public IRoomBuilder SetRating(double rating)
        {
            _room.Rating = rating;
            return this;
        }

        public IRoomBuilder SetAvailability(bool isAvailable)
        {
            _room.IsAvailable = isAvailable;
            return this;
        }

        public Room Build()
        {
            return _room;
        }
    }
}
