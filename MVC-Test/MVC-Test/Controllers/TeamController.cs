using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class TeamController : Controller
    {
        public BasketballContext db { get; set; }
        public TeamController(BasketballContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Teams.ToList());
        }
    }
}
