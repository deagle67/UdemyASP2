using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UdemyASP2.Models;

namespace UdemyASP2.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }

        public int GenreId { get; set; }
    }
}