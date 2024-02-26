using Lab4.Data;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public RoomsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Rooms
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
    {
        return await _context.Rooms.ToListAsync();
    }

    // GET: api/Rooms/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Room>> GetRoom(int id)
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
    public async Task<ActionResult<Room>> PostRoom(Room room)
    {
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

        room.Rating = rating;
        await _context.SaveChangesAsync();

        return NoContent();
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
}

