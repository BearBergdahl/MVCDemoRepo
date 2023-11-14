using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCDemoRepo.Controllers
{
    public class FurnitureController : Controller
    {
        // GET /Furniture
        public IActionResult Index()
        {
            return View();
        }

        // GET /Furniture/Welcome
        public IActionResult Welcome(string department = "Beds", int number = 3) 
        {
            ViewData["Department"] = "You selected department: " + department;
            ViewData["RepeatNumber"] = number;
            return View();
        }
    }
}
