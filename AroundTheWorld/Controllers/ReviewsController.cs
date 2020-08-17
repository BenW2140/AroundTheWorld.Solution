using AroundTheWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace AroundTheWorld.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private AroundTheWorldContext _db;
    public ReviewsController(AroundTheWorldContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string country, string city)
    {
      var query = _db.Reviews.AsQueryable();

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (country != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }
  }
}