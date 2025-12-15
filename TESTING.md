# TESTING.md

## Overview

This project uses unit testing to validate the core logic of three utility features:

1. Count vowels in a string  
2. Detect whether a year is a leap year  
3. Detect whether a number is a palindrome  

All business logic is implemented in a dedicated service class:

- `IUtilityService`
- `UtilityService`

The MVC controller and views are intentionally kept thin and only act as a UI layer to call the service.

---

## Testing Framework and Tools

- **Framework:** NUnit  
- **IDE:** Visual Studio Test Explorer  
- **Pattern:** AAA (Arrange–Act–Assert)

The test project is:

- `MyApp.Tests`

---

## Testing Philosophy

The main goal of the test suite is to verify correctness of the service methods in isolation.

Tests focus on:

- **Typical expected inputs**
- **Edge cases**
- **Branch conditions** (especially for leap year rules)
- **Defensive behavior** (e.g., null/empty string handling)

This approach ensures that the most important logic is stable, predictable, and safe to refactor without breaking behavior.

---

## AAA Pattern Usage

All tests follow the AAA structure.

- **Arrange:** set up input values and create the service  
- **Act:** call the method under test  
- **Assert:** verify the result

Example structure:

```csharp
[Test]
public void CountVowels_WithNormalString_ReturnsCorrectCount()
{
    // ARRANGE
    var service = new UtilityService();
    var input = "Hello World";

    // ACT
    var result = service.CountVowels(input);

    // ASSERT
    Assert.AreEqual(3, result);


How to run unit tests locally
dotnet test --filter "Category!=Integration"

How to run integration tests locally
dotnet test --filter "Category=Integration"
}
