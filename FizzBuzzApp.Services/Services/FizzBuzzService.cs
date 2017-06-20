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
        public Result<FizzBuzzResult> GetFizzBuzz(int input)
        {
            if (input != 0)
            {
                if (input % 3 == 0)
                {
                    return new Result<FizzBuzzResult>(FizzBuzzResult.Fizz);
                }
                if (input % 5 == 0)
                {
                    return new Result<FizzBuzzResult>(FizzBuzzResult.Buzz);

                }
            }
            return new Result<FizzBuzzResult>(FizzBuzzResult.None);

        }
    }
}
