using Lab4.Interfaces.GeoServices;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class GeolocationService : IGeolocationService
    {
        public Coordinates FindCoordinates(string location)
        {
            var responseMessage = new HttpClient().GetAsync($"http://geoserver.com/{location}");
            var res = responseMessage.GetAwaiter().GetResult();
            return new Coordinates { Latitude = 100, Longitude = 100 };
        }
    }
}
