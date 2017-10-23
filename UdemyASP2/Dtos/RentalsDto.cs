using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UdemyASP2.Dtos
{
    public class RentalsDto
    {
        [Required]
        public string Customer { get; set; }

        [Required]
        public string Movie { get; set; }

        [Required]
        public string DateRented { get; set; }

        public string DateReturned { get; set; }
    }
}