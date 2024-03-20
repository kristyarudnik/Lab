using Lab4.Data;
using Lab4.Implementation;
using Lab4.Implementation.Decorators;
using Lab4.Implementation.Factories;
using Lab4.Implementation.Observers;
using Lab4.Implementation.Strategies;
using Lab4.Interfaces;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly RoomFactorySingleton _roomFactorySingleton;
    private readonly RoomFacade _roomFacade;
    private readonly IObserver _bookingObserver;
    private readonly IObserver _ratingObserver;

    public RoomsController(ApplicationDbContext context, RoomFacade roomFacade)
    {
        _context = context;
        _roomFactorySingleton = RoomFactorySingleton.Instance;
        _roomFacade = roomFacade;
        _bookingObserver = new BookingNotification();
        _ratingObserver = new RatingUpdate();
    }

    // GET: api/Rooms
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BaseRoom>>> GetRooms()
    {
        return await _context.Rooms.ToListAsync();
    }

    // GET: api/Rooms/5
    [HttpGet("{id}")]
    public async Task<ActionResult<BaseRoom>> GetRoom(int id)
    {
        var room = await _context.Rooms.FindAsync(id);

        if (room == null)
        {
            return NotFound();
        }

        return room;
    }

    // POST: api/Rooms
    [HttpPost]
    public async Task<ActionResult<Room>> PostRoom(string type, string location, double rating, bool isAvailable)
    {
        IRoomBuilder roomBuilder = new RoomBuilder(type)
                            .SetLocation(location)
                            .SetRating(rating)
                            .SetAvailability(isAvailable);

        var room = roomBuilder.Build();

        room.AddObserver(_bookingObserver);
        room.AddObserver(_ratingObserver);

        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetRoom", new { id = room.Id }, room);
    }

    [HttpPost("CreateByType")]
    public async Task<ActionResult<Room>> CreateRoomByType(string type)
    {
        var roomFactory = _roomFactorySingleton.GetFactory(type);

        var room = roomFactory.CreateRoom();

        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetRoom", new { id = room.Id }, room);
    }

    // PUT: api/Rooms/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRoom(int id, Room room)
    {
        if (id != room.Id)
        {
            return BadRequest();
        }

        _context.Entry(room).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/Rooms/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoom(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null)
        {
            return NotFound();
        }

        _context.Rooms.Remove(room);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // PUT: api/Rooms/5/Rate
    [HttpPut("{id}/Rate")]
    public async Task<IActionResult> RateRoom(int id, [FromBody] double rating)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null)
        {
            return NotFound();
        }
        IRoom standardRoom = new BaseRoom();

        RatingDecorator ratedRoom = new RatingDecorator(standardRoom);
        ratedRoom.Display();

        _roomFacade.RateRoom(room, rating);
        await _context.SaveChangesAsync();

        var lang = Request.Headers.AcceptLanguage.ToString();
        var ratingStr = lang switch
        {
            "en" => GetRatingRoomByLocalization(new EnglishRatingConversionStrategy(), rating),
            "ru" => GetRatingRoomByLocalization(new RussianRatingConversionStrategy(), rating),
            _ => GetRatingRoomByLocalization(new EnglishRatingConversionStrategy(), rating),
        };

        return Ok(ratingStr);
    }

    // PUT: api/Rooms/5/Reserve
    [HttpPut("{id}/Reserve")]
    public async Task<IActionResult> ReserveRoom(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null || !room.IsAvailable)
        {
            return BadRequest("Room is not available.");
        }

        room.IsAvailable = false;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // PUT: api/Rooms/5/CancelReservation
    [HttpPut("{id}/CancelReservation")]
    public async Task<IActionResult> CancelReservation(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null)
        {
            return NotFound();
        }

        room.IsAvailable = true;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private string GetRatingRoomByLocalization(IRatingConversionStrategy strategy, double rating)
    {
        return $"Converted rating = {strategy.ConvertRating(rating)}";
    }
}

