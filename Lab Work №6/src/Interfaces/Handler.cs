using Lab4.Models;

namespace Lab4.Interfaces
{
    public abstract class Handler : IHandler
    {
        protected IHandler _nextHandler;

        public void SetNextHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(BaseRoom room);
    }

}
