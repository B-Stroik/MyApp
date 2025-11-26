using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Services
{
    public class UtilityService : IUtilityService
    {
        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach (var c in input.ToLower())
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }

        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }

        public bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;

            var s = number.ToString();
            var reversed = new string(s.Reverse().ToArray());
            return s == reversed;
        }
    }
}
