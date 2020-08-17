using Microsoft.EntityFrameworkCore;

namespace AroundTheWorld.Models
{
  public class AroundTheWorldContext : DbContext
  {
    public AroundTheWorldContext(DbContextOptions options) : base(options) {}
    public DbSet<Review> Reviews { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, Description = "The furniture was amazing", Rating = 9, Country = "Sweden", City = "Gothenburg", },
          new Review { ReviewId = 2, Description = "Nothing like the original", Rating = 3, Country = "United States", City = "New York", },
          new Review { ReviewId = 3, Description = "As someone who used to live there, its seen better days", Rating = 2, Country = "Italy", City = "Pompeii", },
          new Review { ReviewId = 4, Description = "Classic", Rating = 6, Country = "England", City = "York", }
        );
    }
  }
}