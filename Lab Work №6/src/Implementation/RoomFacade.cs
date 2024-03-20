using Lab4.Implementation.FacadeElements;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class RoomFacade
    {
        private readonly RoomBookingService _roomBookingService;
        private readonly RoomRatingService _roomRatingService;

        public RoomFacade(RoomBookingService roomBookingService, RoomRatingService roomRatingService)
        {
            _roomBookingService = roomBookingService;
            _roomRatingService = roomRatingService;
        }
        public void BookRoom(BaseRoom room)
        {
            _roomBookingService.BookRoom(room);
        }

        public double RateRoom(BaseRoom room, double rating)
        {
            return _roomRatingService.RateRoom(room, rating);
        }
    }
}
