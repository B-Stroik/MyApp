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

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UtilityViewModel());
        }

        [HttpPost]
        public IActionResult CountVowels(UtilityViewModel model)
        {
            if (string.IsNullOrEmpty(model.InputString))
            {
                model.Message = "Please enter a string.";
            }
            else
            {
                model.VowelCountResult = _utilityService.CountVowels(model.InputString);
                model.LastOperation = "CountVowels";
            }

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult CheckLeapYear(UtilityViewModel model)
        {
            if (!model.Year.HasValue)
            {
                model.Message = "Please enter a year.";
            }
            else
            {
                model.IsLeapYearResult = _utilityService.IsLeapYear(model.Year.Value);
                model.LastOperation = "CheckLeapYear";
            }

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult CheckPalindrome(UtilityViewModel model)
        {
            if (!model.Number.HasValue)
            {
                model.Message = "Please enter a number.";
            }
            else
            {
                model.IsPalindromeResult = _utilityService.IsPalindrome(model.Number.Value);
                model.LastOperation = "CheckPalindrome";
            }

            return View("Index", model);
        }
    }
}
