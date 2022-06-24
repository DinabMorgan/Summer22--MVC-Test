using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models;
using System.Linq;

namespace MVC_Test.Models
{
    public class PositionController : Controller
    {
        public BasketballContext db;
        public PositionController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Positions.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Positions.ToList().Where(p => p.Id == id).FirstOrDefault());
        }
    }
}
