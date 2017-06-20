using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Enums;

namespace FizzBuzzApp.Services.Models
{
    public class Result<T>
    {
        public T Value { get; set; }
        public ResultCode ResultCode { get; set; }
    }
}
