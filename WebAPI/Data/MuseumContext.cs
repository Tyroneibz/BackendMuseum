using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

public class MuseumContext : DbContext
{
    public DbSet<MuseumArea> MuseumAreas { get; set; }
    public DbSet<VisitorEntry> VisitorEntries { get; set; }
    public DbSet<VisitorExit> VisitorExits { get; set; }

    public MuseumContext(DbContextOptions<MuseumContext> options)
        : base(options)
    {
    }

}
