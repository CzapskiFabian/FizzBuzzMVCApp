using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Interfaces;
using FizzBuzzApp.Services.Models;
using FizzBuzzApp.Web.Controllers;
using FizzBuzzApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace FizzBuzzServices.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private Mock<IFizzBuzzService> _fizzBuzzServiceMock = new Mock<IFizzBuzzService>();

        private HomeController _homeController;
        [SetUp]
        public void Setup()
        {
            _homeController = new HomeController(_fizzBuzzServiceMock.Object);
        }
        [Test]
        public void IndexGetReturnsCorrectViewModel()
        {
            // arrange 

            // act
            var result = _homeController.Index() as ViewResult;

            // assert
            Assert.IsInstanceOf<FizzBuzzViewModel>(result.Model);
        }

        [Test]
        public void IndexPostReturnsValidViewOnValidInput()
        {
            // arrange 
            var model = new FizzBuzzViewModel();
            _fizzBuzzServiceMock.Setup(x => x.GetFizzBuzz(It.IsAny<int>())).Returns(new Result<string>("Fizz"));
           
            // act
            var result = _homeController.Index(model) as ViewResult;

            // assert
            Assert.IsInstanceOf<FizzBuzzViewModel>(result.Model);
            Assert.AreEqual("Fizz", ((FizzBuzzViewModel)result.Model).Result);
        }
    }
}
