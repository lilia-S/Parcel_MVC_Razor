using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ParcelsController : Controller
  {
    private static Parcel parcel;

    [HttpGet("/parcels")]
    public ActionResult Index()
    { 
      return View(parcel);
    }

    [HttpGet("/parcels/new")]
    pcd ..ublic ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int side1, int side2, int side3, int weight)
    {
      parcel = new Parcel(side1, side2, side3, weight);
      return RedirectToAction("Index");
    }

  }
}