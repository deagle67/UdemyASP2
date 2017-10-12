using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UdemyASP2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [Column(TypeName = "datetime2")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        [Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [MoviesStockBetween1And20]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
        
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}