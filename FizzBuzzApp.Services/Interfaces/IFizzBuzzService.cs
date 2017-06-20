using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Enums;
using FizzBuzzApp.Services.Models;

namespace FizzBuzzApp.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        Result<FizzBuzzResult> GetFizzBuzz(int input);
    }
}
