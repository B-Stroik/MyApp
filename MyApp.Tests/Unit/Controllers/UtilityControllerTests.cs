using Microsoft.AspNetCore.Mvc;
using Moq;
using MyApp.Controllers;
using MyApp.Models;
using MyApp.Services;
using Xunit;

namespace MyApp.Tests.Unit.Controllers
{
    public class UtilityControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult_WithNewUtilityViewModel()
        {
            // Arrange
            var serviceMock = new Mock<IUtilityService>();
            var controller = new UtilityController(serviceMock.Object);

            // Act
            var result = controller.Index();

            // Assert
            var view = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<UtilityViewModel>(view.Model);
        }

        [Fact]
        public void CountVowels_ReturnsIndexView_WithVowelCount_AndSetsLastOperation()
        {
            // Arrange
            var serviceMock = new Mock<IUtilityService>();
            serviceMock.Setup(s => s.CountVowels("hello")).Returns(2);

            var controller = new UtilityController(serviceMock.Object);
            var model = new UtilityViewModel { InputString = "hello" };

            // Act
            var result = controller.CountVowels(model);

            // Assert
            var view = Assert.IsType<ViewResult>(result);
            Assert.Equal("Index", view.ViewName);

            var returnedModel = Assert.IsType<UtilityViewModel>(view.Model);
            Assert.Equal(2, returnedModel.VowelCountResult);
            Assert.Equal("CountVowels", returnedModel.LastOperation);

            serviceMock.Verify(s => s.CountVowels("hello"), Times.Once);
        }

        [Fact]
        public void CheckLeapYear_WhenYearProvided_ReturnsIndexView_SetsResult_AndSetsLastOperation()
        {
            // Arrange
            var serviceMock = new Mock<IUtilityService>();
            serviceMock.Setup(s => s.IsLeapYear(2024)).Returns(true);

            var controller = new UtilityController(serviceMock.Object);
            var model = new UtilityViewModel { Year = 2024 };

            // Act
            var result = controller.CheckLeapYear(model);

            // Assert
            var view = Assert.IsType<ViewResult>(result);
            Assert.Equal("Index", view.ViewName);

            var returnedModel = Assert.IsType<UtilityViewModel>(view.Model);
            Assert.True(returnedModel.IsLeapYearResult);
            Assert.Equal("CheckLeapYear", returnedModel.LastOperation);

            serviceMock.Verify(s => s.IsLeapYear(2024), Times.Once);
        }

    }
}