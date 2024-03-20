using Lab4.Implementation;
using Lab4.Interfaces.GeoServices;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoodsController : ControllerBase
    {
        public CoodsController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> DisplayLocation(string location)
        {
            IExternalGeolocationService externalService = new ExternalGeolocationService();
            IGeolocationService adapter = new ExternalGeolocationAdapter(externalService);

            Coordinates coordinates = adapter.FindCoordinates(location);
            return Ok($"Coordinates for {location}: Latitude {coordinates.Latitude}, Longitude {coordinates.Longitude}");
        }

        [HttpGet("GetLocation")]
        public async Task<IActionResult> DisplayLocationByRealServer(string location)
        {
            IGeolocationService proxy = new GeolocationProxy(new GeolocationService());

            Coordinates coordinates = proxy.FindCoordinates(location);
            return Ok($"Coordinates for {location}: Latitude {coordinates.Latitude}, Longitude {coordinates.Longitude}");
        }
    }
}
