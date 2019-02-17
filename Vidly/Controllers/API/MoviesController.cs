using AutoMapper;
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
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/Movies

        public IEnumerable<MoviesDTO> GetMovies()
        {
            var movies = _context.Movies.ToList().Select(Mapper.Map<Movie, MoviesDTO>);

            return movies;
        }

        //GET api/Movies/1        
        public IHttpActionResult GetMovies(int id)
        {
            var movies = _context.Movies.Single(c => c.ID == id);
            if (movies == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MoviesDTO>(movies));
        }

        //POST api/Movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDTO moviesDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movie = Mapper.Map<MoviesDTO, Movie>(moviesDTO);
            _context.Movies.Add(movie);
            _context.SaveChanges();
            moviesDTO.ID = movie.ID;
            return Created(new Uri(Request.RequestUri + "/" + moviesDTO.ID), moviesDTO);
        }

        //PUT api/Movies/1
        [HttpPut]
        public void UpdateCustomer(int id, MoviesDTO moviesDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieindb = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (movieindb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(moviesDTO, movieindb);

            _context.SaveChanges();
        }
        //DELETE api/Movies/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var movieindb = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (movieindb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieindb);
            _context.SaveChanges();
        }
    }
}
