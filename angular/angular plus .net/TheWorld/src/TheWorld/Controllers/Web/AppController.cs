using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorld.Models;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private WorldContext _context;

        public AppController(WorldContext context)
        {
            _context = context;
        }
        public IActionResult Index() {
            var trips = _context.Trips.OrderBy(t => t.Name).ToList();
            return View(trips);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
