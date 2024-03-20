using Lab4.Models;

namespace Lab4.Interfaces
{
    public interface IHandler
    {
        void SetNextHandler(IHandler nextHandler);

        void HandleRequest(BaseRoom room);
    }
}
