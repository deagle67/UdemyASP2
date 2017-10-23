using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using UdemyASP2.Models;
using System.Data.Entity;
using UdemyASP2.Dtos;

namespace UdemyASP2.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context;

        protected NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            var date = DateTime.Now;

            var customer = _context.Customers
                .Single(c => c.Id == newRentalDto.CustomerId);

            var movies = _context.Movies
                .Where(m => newRentalDto.MoviesIds.Contains(m.Id)).ToList();

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                _context.Rentals.Add(new Rental
                {
                    Customer = customer,
                    Movies = movie,
                    DateRented = date
                });
            }

            _context.SaveChanges();

            return Ok();
        }

        public IHttpActionResult GetNewRentals()
        {
            var rentals = _context.Rentals
                .Include(c => c.Customer)
                .Include(m => m.Movies)
                .ToList().OrderBy(r => r.Customer.Name);

            var rentalsList = new List<RentalsDto>();
            foreach (var rental in rentals)
            {
                var item = new RentalsDto
                {
                    Customer = rental.Customer.Name,
                    Movie = rental.Movies.Name,
                    DateRented = rental.DateRented.ToLongDateString(),
                    DateReturned = rental.DateReturned?.ToLongDateString()
                };
                rentalsList.Add(item);
            }

            return Ok(rentalsList.ToList());
        }
    }
}