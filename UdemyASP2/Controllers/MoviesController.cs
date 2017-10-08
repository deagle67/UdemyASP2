using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyASP.Models;
using UdemyASP.ViewModels;

namespace UdemyASP.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> listMovies = new List<Movie>
        {
            new Movie { Name = "Shrek", ID = 1 },
            new Movie { Name = "Wall-E", ID = 2 }
        };

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World !");
            //return HttpNotFound();
            // return EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            MoviesViewModel moviesViewModel = new MoviesViewModel
            {
                movies = listMovies
            };

            return View(moviesViewModel);
        }
    }
}