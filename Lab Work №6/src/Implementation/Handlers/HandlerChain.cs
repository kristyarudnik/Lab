using Lab4.Interfaces;
using Lab4.Models;

namespace Lab4.Implementation.Handlers
{
    public class HandlerChain
    {
        private readonly IHandler _bookingHandler;
        private readonly IHandler _ratingHandler;

        public HandlerChain()
        {
            _bookingHandler = new BookingHandler();
            _ratingHandler = new RatingHandler();

            _bookingHandler.SetNextHandler(_ratingHandler);
        }

        public void ProcessRoom(BaseRoom room)
        {
            _bookingHandler.HandleRequest(room);
        }
    }
}
