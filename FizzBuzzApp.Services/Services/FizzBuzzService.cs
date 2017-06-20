using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Enums;
using FizzBuzzApp.Services.Interfaces;
using FizzBuzzApp.Services.Models;

namespace FizzBuzzApp.Services.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private IApplicationLogger _logger;
        public FizzBuzzService(IApplicationLogger logger)
        {
            _logger = logger;
        }

        public Result<string> GetFizzBuzz(int input)
        {
            try
            {
                if (input != 0)
                {
                    if (input % 3 == 0)
                    {
                        return new Result<string>("Fizz");
                    }
                    if (input % 5 == 0)
                    {
                        return new Result<string>("Buzz");

                    }
                }
                return new Result<string>("");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                return new Result<string>(ResultCode.Error, "Application Failed, please try again later");
            }
        }
    }
}
