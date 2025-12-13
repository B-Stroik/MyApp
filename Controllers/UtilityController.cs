using Microsoft.AspNetCore.Mvc;
using MyApp.Services;

namespace MyApp.Controllers
{
    public class UtilityController : Controller
    {
        private readonly IUtilityService _utilityService;

        public UtilityController(IUtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // just returns the page with the three tools
            return View();
        }

        // Count Vowels ---------------------------------------------------
        [HttpPost]
        public IActionResult CountVowels(string inputString)
        {
            // make sure we never pass null to the service
            var count = _utilityService.CountVowels(inputString ?? string.Empty);
            ViewBag.VowelResult = count;

            return View("Index");
        }

        // Leap Year ------------------------------------------------------
        [HttpPost]
        public IActionResult CheckLeapYear(int year)
        {
            var isLeap = _utilityService.IsLeapYear(year);
            ViewBag.LeapYearResult = isLeap;

            return View("Index");
        }

        // Palindrome -----------------------------------------------------
        [HttpPost]
        public IActionResult CheckPalindrome(string number)
        {
            var isPalindrome = _utilityService.IsPalindrome(number ?? string.Empty);
            ViewBag.PalindromeResult = isPalindrome;

            return View("Index");
        }
    }
}
