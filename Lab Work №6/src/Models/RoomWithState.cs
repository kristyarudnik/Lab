using Lab4.Implementation.States;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class RoomWithState
    {
        private IRoomState currentState;

        public RoomWithState()
        {
            currentState = new AvailableState();
        }

        public void SetState(IRoomState state)
        {
            currentState = state;
        }

        public void Book()
        {
            currentState.BookRoom(this);
        }

        public void CheckIn()
        {
            currentState.CheckIn(this);
        }

        public void CheckOut()
        {
            currentState.CheckOut(this);
        }
    }
}
