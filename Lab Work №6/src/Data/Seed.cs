using Lab4.Models;

namespace Lab4.Data;

public class Seed
{
    public static async Task SeedData(ApplicationDbContext context)
    {
        if (!context.Rooms.Any())
        {
            var rooms = new List<BaseRoom>
            {
                new Room { Type = "Single", Location = "1st floor", IsAvailable = true, Rating = 4.5 },
                new Room { Type = "Double", Location = "2nd floor", IsAvailable = true, Rating = 4.2 },
                new Room { Type = "Suite", Location = "3rd floor", IsAvailable = false, Rating = 4.8 }
            };

            await context.Rooms.AddRangeAsync(rooms);
            await context.SaveChangesAsync();
        }
    }
}