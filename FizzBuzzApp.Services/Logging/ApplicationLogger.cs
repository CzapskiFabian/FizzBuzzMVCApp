using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzApp.Services.Interfaces;

namespace FizzBuzzApp.Services.Logging
{
    // TODO: Out of scope for this exercise
    public class ApplicationLogger : IApplicationLogger
    {
        public void Log(string message)
        {

        }

        public void Log(Exception ex, string message = null)
        {
            
        }
    }
}
