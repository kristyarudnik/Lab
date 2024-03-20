using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<BaseRoom> Rooms { get; set; }
}
