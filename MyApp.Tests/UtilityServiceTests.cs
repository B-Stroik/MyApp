using NUnit.Framework;
using MyApp.Services;

using Assert = NUnit.Framework.Assert;

namespace MyApp.Tests
{
    [TestFixture]
    public class UtilityServiceTests
    {
        private IUtilityService _service = null!;

        [SetUp]
        public void Setup()
        {
            _service = new UtilityService();
        }

        // -------------------------------
        // CountVowels Tests (4)
        // -------------------------------

        [Test]
        public void CountVowels_WithNormalString_ReturnsCorrectCount()
        {
            // Arrange
            var input = "Hello World";

            // Act
            var result = _service.CountVowels(input);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void CountVowels_WithUppercaseVowels_ReturnsCorrectCount()
        {
            var input = "AEIOU";
            var result = _service.CountVowels(input);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void CountVowels_WithEmptyString_ReturnsZero()
        {
            var input = "";
            var result = _service.CountVowels(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CountVowels_WithNull_ReturnsZero()
        {
            string? input = null;
            var result = _service.CountVowels(input);
            Assert.That(result, Is.EqualTo(0));
        }

        // -------------------------------
        // IsLeapYear Tests (4)
        // -------------------------------

        [Test]
        public void IsLeapYear_YearDivisibleBy400_ReturnsTrue()
        {
            var year = 2000;
            var result = _service.IsLeapYear(year);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLeapYear_YearDivisibleBy100ButNot400_ReturnsFalse()
        {
            var year = 1900;
            var result = _service.IsLeapYear(year);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsLeapYear_YearDivisibleBy4ButNot100_ReturnsTrue()
        {
            var year = 2024;
            var result = _service.IsLeapYear(year);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsLeapYear_YearNotDivisibleBy4_ReturnsFalse()
        {
            var year = 2023;
            var result = _service.IsLeapYear(year);
            Assert.That(result, Is.False);
        }

        // -------------------------------
        // IsPalindrome Tests (4)
        // -------------------------------

        [Test]
        public void IsPalindrome_WithPalindromeNumber_ReturnsTrue()
        {
            var number = 121;
            var result = _service.IsPalindrome(number);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_WithNonPalindromeNumber_ReturnsFalse()
        {
            var number = 123;
            var result = _service.IsPalindrome(number);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_WithNegativeNumber_ReturnsFalse()
        {
            var number = -121;
            var result = _service.IsPalindrome(number);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_NumberEndingInZero_ReturnsFalse()
        {
            var number = 10;
            var result = _service.IsPalindrome(number);
            Assert.That(result, Is.False);
        }
    }
}
