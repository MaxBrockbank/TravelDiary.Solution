using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;
namespace TravelDiary.Controllers 
{
  
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost ("/places")]
    public ActionResult Create(string place, string description)
    {
      Place newPlace = new Place(place, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
        Place place = Place.Find(id);
        return View(place);
    }
  }

}