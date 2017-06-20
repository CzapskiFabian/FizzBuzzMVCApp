using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp.Services.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
        void Log(Exception ex, string message = null);
    }
}
