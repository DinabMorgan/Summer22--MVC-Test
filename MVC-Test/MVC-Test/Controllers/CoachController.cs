using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers;

public class CoachController : Controller
{
     public BasketballContext db { get; set; }
    public CoachController(BasketballContext db)
    {
        this.db = db;
    }

    public IActionResult Index()
    {
        return View(db.Coaches.ToList());
    }
    public IActionResult Create()
    {
        return View(new Coach());
    }
}
