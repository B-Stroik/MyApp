using Microsoft.AspNetCore.Mvc;
using MyApp.Services;

namespace MyApp.Controllers
{
    public class UtilityController : Controller
    {
        private readonly UtilityService _utilityService;

        public UtilityController(UtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
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
