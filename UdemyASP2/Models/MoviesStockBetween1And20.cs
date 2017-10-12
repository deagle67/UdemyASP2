using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UdemyASP2.Models
{
    public class MoviesStockBetween1And20 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            if(movie.NumberInStock == 0)
            {
                return new ValidationResult("The number in stock must be between 1 and 20");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}