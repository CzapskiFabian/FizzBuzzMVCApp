using FizzBuzzApp.Services.Enums;
using FizzBuzzApp.Services.Interfaces;
using FizzBuzzApp.Services.Models;
using FizzBuzzApp.Services.Services;
using Moq;
using NUnit.Framework;


namespace FizzBuzzApp.Services.Test.Services
{
    [TestFixture]
    public class FizzBuzzServiceTests 
    {
        [Test]
        [TestCase(-300, "Fizz")]
        [TestCase(-90, "Fizz")]
        [TestCase(-6, "Fizz")]
        [TestCase(-3, "Fizz")]
        [TestCase(3, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]

        [TestCase(-50, "Buzz")]
        [TestCase(-5, "Buzz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(100, "Buzz")]
        [TestCase(5000, "Buzz")]

        [TestCase(1, "")]
        [TestCase(2, "")]
        [TestCase(0, "")]
        [TestCase(986, "")]
        [TestCase(-13, "")]
        [TestCase(1001, "")]
        [TestCase(-1001, "")]
        public void GetFizzBuzzReturnsCorrentlyOnInput(int testvalue, string expectedResult)
        {
            // arrange
            Mock<IApplicationLogger> loggerMock = new Mock<IApplicationLogger>();
            FizzBuzzService sut = new FizzBuzzService(loggerMock.Object);

            // act
            var result = sut.GetFizzBuzz(testvalue);

            // assert
            Assert.IsInstanceOf<Result<string>>(result);
            Assert.AreEqual(expectedResult, result.Value);
        }


    }
}
