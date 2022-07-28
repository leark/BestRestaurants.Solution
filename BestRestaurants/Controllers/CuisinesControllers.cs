using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BestRestaurants.Models;


namespace BestRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisinesController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      ViewBag.PageTitle = "View All Cuisines";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Cuisine";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisine cuisineFound = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      ViewBag.Restaurants = _db.Restaurants.Where(restaurant => restaurant.CuisineId == cuisineFound.CuisineId).ToList();
      return View(cuisineFound);
    }

    public ActionResult Edit(int id)
    {
      Cuisine cuisineFound = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(cuisineFound);
    }

    [HttpPost]
    public ActionResult Edit(Cuisine cuisine)
    {
      _db.Entry(cuisine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Cuisine cuisineFound = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(cuisineFound);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult Deleted(int id)
    {
      Cuisine cuisineFound = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      _db.Cuisines.Remove(cuisineFound);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}