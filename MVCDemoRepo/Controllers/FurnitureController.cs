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
        public string Welcome(string department, int number = 3) 
        { 
            return HtmlEncoder.Default.Encode($"Welcome to Mykea {department}-department you are visitor {number}");
        }
    }
}
