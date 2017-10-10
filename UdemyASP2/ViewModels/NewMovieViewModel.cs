using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyASP2.Models;

namespace UdemyASP2.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}