using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTO;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDTO newRental)
        {
            //var customer = _context.Customers.Single(c => c.ID == newRental.CustomerID);
            //var movies = _context.Movies.Where(m => newRental.MovieIDs.Contains(m.ID));

            //foreach (var movie in movies)
            //{
            //    movie.NumberAvailable--;

            //    var rental = new Rental
            //    {
            //        Customer = customer,
            //        Movie = movie,
            //        DateRented = DateTime.Now
            //    };
            //    _context.Rentals.Add(rental);
            //}

            //_context.SaveChanges();
            return Ok();
        }
    }
}
