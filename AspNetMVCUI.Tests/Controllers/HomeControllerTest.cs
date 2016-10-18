using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetMVCUI.Controllers;
using AspNetMVCUI.Models;
using SOLIDFizzBuzz;
using Moq;

namespace AspNetMVCUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly Mock<IDividendProcessor> processor;

        public HomeControllerTest()
        {
            this.processor = new Mock<IDividendProcessor>();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = this.CreateSUT();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexPostViewBag_ShouldHaveResultFromDividendProcessor()
        {
            // Arrange
            HomeController controller = this.CreateSUT();
            var model = new FizzBuzzModel { Number = It.IsAny<int>() };
            var expected = It.IsAny<string>();
            this.processor.Setup(m => m.Process(model.Number)).Returns(expected);

            // Act
            ViewResult result = controller.Index(model) as ViewResult;

            // Assert
            Assert.AreEqual(expected, result.ViewBag.Result);
        }
        
        private HomeController CreateSUT()
        {
            return new HomeController(this.processor.Object);
        }
    }
}
