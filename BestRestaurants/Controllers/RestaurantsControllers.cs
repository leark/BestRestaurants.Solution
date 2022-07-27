using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BestRestaurants.Models;


namespace BestRestaurants.Controllers
{
  public class CuisineController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisineController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      ViewBag.PageTitle = "View All Cuisines";
      return View(model);
    }
  }
}