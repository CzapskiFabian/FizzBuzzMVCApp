using FizzBuzzApp.Services.Enums;
using FizzBuzzApp.Services.Models;
using FizzBuzzApp.Services.Services;
using NUnit.Framework;


namespace FizzBuzzApp.Services.Test.Services
{
    [TestFixture]
    public class FizzBuzzServiceTests 
    {
        [Test]
        [TestCase(-300, FizzBuzzResult.Fizz)]
        [TestCase(-90, FizzBuzzResult.Fizz)]
        [TestCase(-6, FizzBuzzResult.Fizz)]
        [TestCase(-3, FizzBuzzResult.Fizz)]
        [TestCase(3, FizzBuzzResult.Fizz)]
        [TestCase(9, FizzBuzzResult.Fizz)]
        [TestCase(12, FizzBuzzResult.Fizz)]

        [TestCase(-50, FizzBuzzResult.Buzz)]
        [TestCase(-5, FizzBuzzResult.Buzz)]
        [TestCase(5, FizzBuzzResult.Buzz)]
        [TestCase(10, FizzBuzzResult.Buzz)]
        [TestCase(100, FizzBuzzResult.Buzz)]
        [TestCase(5000, FizzBuzzResult.Buzz)]

        [TestCase(1, FizzBuzzResult.None)]
        [TestCase(2, FizzBuzzResult.None)]
        [TestCase(0, FizzBuzzResult.None)]
        [TestCase(987, FizzBuzzResult.None)]
        [TestCase(-13, FizzBuzzResult.None)]
        [TestCase(1001, FizzBuzzResult.None)]
        [TestCase(-1001, FizzBuzzResult.None)]
        public void GetFizzBuzzReturnsCorrentlyOnInput(int testvalue, FizzBuzzResult expectedResult)
        {
            // arrange
            FizzBuzzService sut = new FizzBuzzService();

            // act
            var result = sut.GetFizzBuzz(testvalue);

            // assert
            Assert.IsInstanceOf<Result<FizzBuzzResult>>(result);
            Assert.AreEqual(expectedResult, result.Value);
        }


    }
}
