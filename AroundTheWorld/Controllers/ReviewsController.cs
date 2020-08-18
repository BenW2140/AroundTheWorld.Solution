using AroundTheWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace AroundTheWorld.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsV1Controller : ControllerBase
  {
    private AroundTheWorldContext _db;
    public ReviewsV1Controller(AroundTheWorldContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get()
    {
      return _db.Reviews.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }
  }
}