using System.ComponentModel.DataAnnotations;

namespace AroundTheWorld.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    [StringLength(300)]
    public string Description { get; set; }
    [Required]
    [Range(0, 10)]
    public int Rating { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
  }
}