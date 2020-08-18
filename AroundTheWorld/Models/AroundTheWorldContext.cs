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
          new Destination { DestinationId = 2, Country = "United States", City = "New York" },
          new Destination { DestinationId = 3, Country = "Italy", City = "Pompeii" },
          new Destination { DestinationId = 4, Country = "England", City = "York" },
          new Review { ReviewId = 1, DestinationId = 1, Description = "The furniture was amazing", Rating = 9 },
          new Review { ReviewId = 2, DestinationId = 2, Description = "Nothing like the original", Rating = 3 },
          new Review { ReviewId = 3, DestinationId = 3, Description = "As someone who used to live there, its seen better days", Rating = 2 },
          new Review { ReviewId = 4, DestinationId = 4, Description = "Classic", Rating = 6 }
        );
    }
  }
}