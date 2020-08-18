using Microsoft.EntityFrameworkCore;

namespace AroundTheWorld.Models
{
  public class AroundTheWorldContext : DbContext
  {
    public AroundTheWorldContext(DbContextOptions options) : base(options) {}
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Destination { DestinationId = 1, Country = "Sweden", City = "Gothenburg" },
          new Review { ReviewId = 1, Description = "The furniture was amazing", Rating = 9 },
          new Review { ReviewId = 2, Description = "Nothing like the original", Rating = 3 },
          new Review { ReviewId = 3, Description = "As someone who used to live there, its seen better days", Rating = 2 },
          new Review { ReviewId = 4, Description = "Classic", Rating = 6 }
        );
    }
  }
}