using Lab4.Models;

namespace Lab4.Interfaces.GeoServices
{
    public interface IExternalGeolocationService
    {
        void Connect(string apiKey);
        Coordinates GetCoordinates(string address);
    }
}
