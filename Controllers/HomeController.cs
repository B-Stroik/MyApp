using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        // GET /
        [HttpGet("/")]
        public IActionResult Index()
        {
            // Redirect root URL to Utility/Index
            return RedirectToAction("Index", "Utility");
        }
    }
}
