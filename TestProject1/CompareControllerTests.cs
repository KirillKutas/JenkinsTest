using Moq;
using WebApplication1.Controllers;
using WebApplication1.Services;
using Xunit;

namespace TestProject1
{
    public class CompareControllerTests
    {
        private const int NumberA = 5;
        private const int NumberB = 6;
        [Fact]
        public void CompareTest()
        {
            //Arrange
            var mock = new Mock<ICompareService>();
            mock.Setup(service => service.Compare(NumberA, NumberB)).Returns(NumberA > NumberB);
            var controller = new CompareController(mock.Object);

            // Act
            var result = controller.Compare(NumberA, NumberB);

            // Assert
            Assert.IsType<bool>(result);
            Assert.Equal(NumberA > NumberB, result);
        }
    }
}
