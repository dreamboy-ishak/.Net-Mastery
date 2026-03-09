using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // Home page
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to the Hello MVC App!";
            ViewData["DateTime"] = DateTime.Now.ToString("F");
            return View();
        }

        // About page
        public IActionResult About()
        {
            ViewBag.Info = "This is a simple MVC demo for learning.";
            return View();
        }

        // Contact page
        public IActionResult Contact()
        {
            ViewBag.ContactEmail = "support@example.com";
            return View();
        }
    }
}