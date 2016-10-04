using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac.Extras.Moq;
using Moq;
using SOLIDFizzBuzz;

namespace SOLIDFizzBuzzTests
{
    [TestClass]
    public class DividendProcessorTests
    {
        [TestMethod]
        public void Process_ShouldReturnInputAsString_WhenInputNotHandledByRule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                var sut = mock.Create<DividendProcessor>();

                // Act
                var result = sut.Process(3);

                // Assert
                Assert.AreEqual(result, "3");
            }
        }

        [TestMethod]
        public void Process_ShouldReturnRuleMessage_WhenInputHandledByRule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                const int dividend = 25;
                const int divisor = 5;

                var buzzRule = mock.Mock<IDividendRule>();
                buzzRule.Setup(x => x.Divisor).Returns(divisor);
                buzzRule.Setup(x => x.Message).Returns("Buzz");

                var sut = mock.Create<DividendProcessor>();

                // Act
                var result = sut.Process(dividend);

                // Assert
                Assert.AreEqual(result, buzzRule.Object.Message);
            }
        }

        [TestMethod]
        public void Process_ShouldHandleInputWithGreatestDivisor_WhenInputCanBeHandledByMoreThanOneRule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                const int dividend = 45;
                const int smallDivisor = 5;
                const int bigDivisor = 15;

                var buzzRule = new Mock<IDividendRule>();
                buzzRule.Setup(x => x.Divisor).Returns(smallDivisor);
                buzzRule.Setup(x => x.Message).Returns("Buzz");

                var fizzBuzzRule = new Mock<IDividendRule>();
                fizzBuzzRule.Setup(x => x.Divisor).Returns(bigDivisor);
                fizzBuzzRule.Setup(x => x.Message).Returns("FizzBuzz");

                var rules = new List<IDividendRule>
                {
                    buzzRule.Object,
                    fizzBuzzRule.Object
                };

                mock.Provide<IEnumerable<IDividendRule>>(rules);

                var sut = mock.Create<DividendProcessor>();

                // Act
                var result = sut.Process(dividend);

                // Assert
                Assert.AreEqual(result, fizzBuzzRule.Object.Message);
            }
        }

        [TestMethod]
        public void Process_ShouldReturnZero_WhenInputIsZero()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange
                var sut = mock.Create<DividendProcessor>();

                // Act
                var result = sut.Process(0);

                // Assert
                Assert.AreEqual(result, "0");
            }
        }
    }

    
}
