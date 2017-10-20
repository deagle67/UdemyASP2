using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyASP2.Models
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer{ get; set; }
        [Required]
        public Movie Movies { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DateRented { get; set; }
       
        [Column(TypeName = "datetime2")]
        public DateTime? DateReturned { get; set; }

    }
}