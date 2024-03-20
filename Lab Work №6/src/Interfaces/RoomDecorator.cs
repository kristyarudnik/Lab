namespace Lab4.Interfaces
{
    public abstract class RoomDecorator : IRoom
    {
        protected IRoom _room;

        public RoomDecorator(IRoom room)
        {
            _room = room;
        }

        public virtual void Display()
        {
            _room.Display();
        }
    }
}
