namespace MyApp.Services
{
    public interface IUtilityService
    {
        int CountVowels(string input);
        bool IsLeapYear(int year);
        bool IsPalindrome(string number);
    }
}
