using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyASP2.Models;
using System.ComponentModel.DataAnnotations;

namespace UdemyASP2.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [MoviesStockBetween1And20]
        [Range(1,20)]
        public int? NumberInStock { get; set; }

        [Required]
        [Range(0, 20)]
        [Display(Name = "Number Available")]
        public int NumberAvailable { get; set; }

        public int GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            NumberAvailable = movie.NumberAvailable;
        }

    }
}