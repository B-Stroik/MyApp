namespace MyApp.Models
{
    public class UtilityViewModel
    {
        // Inputs
        public string? InputString { get; set; }
        public int? Year { get; set; }
        public int? Number { get; set; }

        // Results
        public int? VowelCountResult { get; set; }
        public bool? IsLeapYearResult { get; set; }
        public bool? IsPalindromeResult { get; set; }

        public string? Message { get; set; }
        public string? LastOperation { get; set; }
    }
}