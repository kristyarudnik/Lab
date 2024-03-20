using Lab4.Interfaces.GeoServices;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class ExternalGeolocationService : IExternalGeolocationService
    {
        public void Connect(string apiKey)
        {
            Console.WriteLine("Connection to geo_api" + " " + apiKey);
        }

        public Coordinates GetCoordinates(string address)
        {
            return new Coordinates
            {
                Latitude = 10,
                Longitude = 10
            };
        }
    }
}
