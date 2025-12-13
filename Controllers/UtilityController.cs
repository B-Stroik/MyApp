using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
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

        // GET /Utility
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UtilityViewModel());
        }

        // POST /Utility/CountVowels
        [HttpPost]
        public IActionResult CountVowels(UtilityViewModel model)
        {
            model.VowelCountResult = _utilityService.CountVowels(model.InputString ?? "");
            model.LastOperation = "CountVowels";
            return View("Index", model);
        }

        // POST /Utility/CheckLeapYear
        [HttpPost]
        public IActionResult CheckLeapYear(UtilityViewModel model)
        {
            if (model.Year.HasValue)
                model.IsLeapYearResult = _utilityService.IsLeapYear(model.Year.Value);

            model.LastOperation = "CheckLeapYear";
            return View("Index", model);
        }

        // POST /Utility/CheckPalindrome
        [HttpPost]
        public IActionResult CheckPalindrome(UtilityViewModel model)
        {
            if (model.Number.HasValue)
                model.IsPalindromeResult = _utilityService.IsPalindrome(model.Number.Value);

            model.LastOperation = "CheckPalindrome";
            return View("Index", model);
        }
    }
}
