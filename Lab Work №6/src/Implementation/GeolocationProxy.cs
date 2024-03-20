using Lab4.Interfaces.GeoServices;
using Lab4.Models;

namespace Lab4.Implementation
{
    public class GeolocationProxy : IGeolocationService
    {
        private readonly GeolocationService _realService;
        private readonly List<string> _authorizedUsers = new List<string> { "admin", "manager" };

        public GeolocationProxy(GeolocationService service)
        {
            _realService = service;
        }

        public Coordinates FindCoordinates(string location)
        {
            if (IsUserAuthorized())
            {
                return _realService.FindCoordinates(location);
            }
            else
            {
                throw new UnauthorizedAccessException("Access denied. You are not authorized to use geolocation service.");
            }
        }

        private bool IsUserAuthorized()
        {
            return _authorizedUsers.Any();
        }
    }
}
