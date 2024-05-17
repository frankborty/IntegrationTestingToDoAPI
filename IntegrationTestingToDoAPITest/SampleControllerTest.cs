using IntegrationTestingToDoAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationTestingToDoAPITest
{
    public class SampleControllerTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var controller = new SampleController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Hello World", okResult.Value);
        }
    }
}