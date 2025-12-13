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

        public bool IsPalindrome(int number)
        {
            var s = number.ToString();
            var reversed = new string(s.Reverse().ToArray());
            return s == reversed;
        }
    }
}
