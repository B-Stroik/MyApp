using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using Xunit;

namespace MyApp.Tests.Integration
{
    public class UtilityRoutesTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public UtilityRoutesTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        [Trait("Category", "Integration")]
        public async Task Get_UtilityIndex_ReturnsOk_AndHtml()
        {
            // Arrange
            var url = "/Utility";

            // Act
            var response = await _client.GetAsync(url);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.StartsWith("text/html", response.Content.Headers.ContentType?.MediaType);
        }

        [Fact]
        [Trait("Category", "Integration")]
        public async Task Post_CountVowels_ReturnsOk_AndHtml()
        {
            // Arrange
            var url = "/Utility/CountVowels";
            var form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("InputString", "hello")
            });

            // Act
            var response = await _client.PostAsync(url, form);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.StartsWith("text/html", response.Content.Headers.ContentType?.MediaType);
        }
    }
}
