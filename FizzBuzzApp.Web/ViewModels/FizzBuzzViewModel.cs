using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace FizzBuzzApp.Web.ViewModels
{
    public class FizzBuzzViewModel
    {
        [DisplayName("Fizz Bar Input")]
        [Required]
        public int Input { get; set; }

        public string Result { get; set; }
    }
}
