using Moq;
using NUnit.Framework;
using WebApplication1.Controllers;
using WebApplication1.Services;

namespace TestProject2
{
    public class Tests
    {
        private const int NumberA = 5;
        private const int NumberB = 6;
        private CompareController _compareController;

        [SetUp]
        public void Setup()
        {
            var mock = new Mock<ICompareService>();
            mock.Setup(service => service.Compare(NumberA, NumberB)).Returns(NumberA > NumberB);
            _compareController = new CompareController(mock.Object);
        }

        [Test]
        public void Test1()
        {
            var result = _compareController.Compare(NumberA, NumberB);

            Assert.AreEqual(NumberA > NumberB, result);
        }
    }
}