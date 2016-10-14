using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetMVCUI.Controllers;
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
        
        private HomeController CreateSUT()
        {
            return new HomeController(this.processor.Object);
        }
    }
}
