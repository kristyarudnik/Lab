using Lab4.Interfaces.GeoServices;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class ExternalGeolocationAdapter : IGeolocationService
    {
        private readonly IExternalGeolocationService _externalService;

        public ExternalGeolocationAdapter(IExternalGeolocationService externalService)
        {
            _externalService = externalService;
        }

        public Coordinates FindCoordinates(string location)
        {
            _externalService.Connect("geo_api_key");

            var externalCoordinates = _externalService.GetCoordinates(location);

            return new Coordinates
            {
                Latitude = externalCoordinates.Latitude,
                Longitude = externalCoordinates.Longitude
            };
        }
    }
}
