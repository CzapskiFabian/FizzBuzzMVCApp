using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzApp.Services.Enums;
using FizzBuzzApp.Services.Interfaces;
using FizzBuzzApp.Services.Services;
using FizzBuzzApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        public HomeController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }
        public IActionResult Index()
        {
            return View(new FizzBuzzViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FizzBuzzViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _fizzBuzzService.GetFizzBuzz(model.Input);

            model.Result = result.Value;

            return View(model);
        }
    }
}
