using Lab4.Models;

namespace Lab4.Interfaces.GeoServices
{
    public interface IGeolocationService
    {
        Coordinates FindCoordinates(string location);
    }
}
