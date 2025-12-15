using Xunit;
using MyApp.Services;

namespace MyApp.Tests.Unit.Services
{
    public class UtilityServiceTests
    {
        private readonly IUtilityService _service;

        public UtilityServiceTests()
        {
            _service = new UtilityService();
        }

        // -------------------------------
        // CountVowels Tests (4)
        // -------------------------------

        [Fact]
        public void CountVowels_WithNormalString_ReturnsCorrectCount()
        {
            // Arrange
            var input = "Hello World";

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void CountVowels_WithUppercaseVowels_ReturnsCorrectCount()
        {
            // Arrange
            var input = "AEIOU";

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CountVowels_WithEmptyString_ReturnsZero()
        {
            // Arrange
            var input = "";

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountVowels_WithNull_ReturnsZero()
        {
            // Arrange
            string? input = null;

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.Equal(0, result);
        }

        // -------------------------------
        // IsLeapYear Tests (4)
        // -------------------------------

        [Fact]
        public void IsLeapYear_YearDivisibleBy400_ReturnsTrue()
        {
            // Arrange
            var year = 2000;

            // Act
            var result = _service.IsLeapYear(year);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLeapYear_YearDivisibleBy100ButNot400_ReturnsFalse()
        {
            // Arrange
            var year = 1900;

            // Act
            var result = _service.IsLeapYear(year);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsLeapYear_YearDivisibleBy4ButNot100_ReturnsTrue()
        {
            // Arrange
            var year = 2024;

            // Act
            var result = _service.IsLeapYear(year);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLeapYear_YearNotDivisibleBy4_ReturnsFalse()
        {
            // Arrange
            var year = 2023;

            // Act
            var result = _service.IsLeapYear(year);

            // Assert
            Assert.False(result);
        }

        // -------------------------------
        // IsPalindrome Tests (4)
        // -------------------------------

        [Fact]
        public void IsPalindrome_WithPalindromeNumber_ReturnsTrue()
        {
            // Arrange
            var number = 121;

            // Act
            var result = _service.IsPalindrome(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_WithNonPalindromeNumber_ReturnsFalse()
        {
            // Arrange
            var number = 123;

            // Act
            var result = _service.IsPalindrome(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_WithNegativeNumber_ReturnsFalse()
        {
            // Arrange
            var number = -121;

            // Act
            var result = _service.IsPalindrome(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_NumberEndingInZero_ReturnsFalse()
        {
            // Arrange
            var number = 10;

            // Act
            var result = _service.IsPalindrome(number);

            // Assert
            Assert.False(result);
        }
    }
}
