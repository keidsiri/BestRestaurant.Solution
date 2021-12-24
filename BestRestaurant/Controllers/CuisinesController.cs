using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace BestRestaurant.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantContext _db;

    public CuisinesController(BestRestaurantContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      List<Cuisine> model = _db.Cuisines.ToList();  // Match with table name
      return View(model);
    }

    [HttpPost]
    public ActionResult Index(int cuisineId)
    {
      List<Restaurant> restaurantList = _db.Restaurants.ToList();
      var sortedList = restaurantList.OrderBy(restaurant => restaurant.CuisineId = cuisineId).ToList();
      return View("Search", sortedList);
    }

    public ActionResult Create()
    {
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
        Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        return View(thisCuisine);
    }

    public ActionResult Edit(int id)
    {
        var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        return View(thisCuisine);
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
        var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine=> cuisine.CuisineId == id);
        return View(thisCuisine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisCuisine= _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
        _db.Cuisines.Remove(thisCuisine);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Search(List<Restaurant> sortedList)
    {
        var model = sortedList;
        return View(model);
    }
  }
}