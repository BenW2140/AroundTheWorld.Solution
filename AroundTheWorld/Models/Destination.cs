using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AroundTheWorld.Models
{
  public class Destination
  {
    public Destination()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int DestinationId { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}