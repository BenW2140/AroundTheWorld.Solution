using AroundTheWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace AroundTheWorld.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/{v:1.0}/[controller]")]
  [ApiController]
  public class DestinationsV1Controller : Controller
  {
    private AroundTheWorldContext _db;
    public DestinationsV1Controller(AroundTheWorldContext db)
    {
      _db = db;
    }
    public ActionResult<IEnumerable<Destination>> Get(string country, string city)
    {
      var query = _db.Destinations.AsQueryable();

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      return query.ToList();
    }
  }
}