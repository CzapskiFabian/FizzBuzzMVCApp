using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Enums;

namespace FizzBuzzApp.Services.Models
{
    public class Result<T>
    {
        public T Value { get; }
        public ResultCode ResultCode { get; }

        public Result(T value)
        {
            Value = value;
            ResultCode = ResultCode.Ok;
        }

        public Result(ResultCode resultCode)
        {
            ResultCode = resultCode;
        }
    }
}
