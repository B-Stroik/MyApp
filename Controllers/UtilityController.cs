using Microsoft.AspNetCore.Mvc;
using MyApp.Services;

namespace MyApp.Controllers
{
    public class UtilityController : Controller
    {
        private readonly UtilityService _utilityService;

        public UtilityController()
        {
            // simple manual creation; matches how your tests use it
            _utilityService = new UtilityService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            // just returns the view with the three tools
            return View();
        }

        [HttpPost]
        public IActionResult CountVowels(string inputString)
        {
            int count = _utilityService.CountVowels(inputString);
            ViewBag.VowelResult = count;
            return View("Index");
        }

        [HttpPost]
        public IActionResult CheckLeapYear(int year)
        {
            bool isLeap = _utilityService.IsLeapYear(year);
            ViewBag.LeapYearResult = isLeap;
            return View("Index");
        }

        [HttpPost]
        public IActionResult CheckPalindrome(int number)
        {
            bool isPal = _utilityService.IsPalindrome(number);
            ViewBag.PalindromeResult = isPal;
            return View("Index");
        }
    }
}
