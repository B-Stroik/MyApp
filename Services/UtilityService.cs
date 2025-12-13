using System.Linq;

namespace MyApp.Services
{
    public class UtilityService : IUtilityService
    {
        public int CountVowels(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            var vowels = "aeiouAEIOU";
            return input.Count(c => vowels.Contains(c));
        }

        public bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        public bool IsPalindrome(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) return false;
            var trimmed = number.Trim();
            var reversed = new string(trimmed.Reverse().ToArray());
            return trimmed == reversed;
        }
    }
}
