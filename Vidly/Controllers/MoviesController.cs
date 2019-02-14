using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c=>c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Edit(int id)
        {
            MoviesViewModel viewModel = null;
            if (id != 0)
            {
                var movie = _context.Movies.Include(c => c.Genre).ToList().FirstOrDefault(x => x.ID == id);
                viewModel = new MoviesViewModel()
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()
                };
            }
            else
            {
                viewModel = new MoviesViewModel()
                {
                    Movie = new Movie(),
                    Genres = _context.Genres.ToList()
                };
            }
            return View("MovieForm", viewModel);
        }

        public ActionResult Save(Movie Movie)
        {
            if (Movie.ID == 0)
            {
                Movie.DateAdded = DateTime.Today;
                _context.Movies.Add(Movie);
            }
            else
            {
                var inDB = _context.Movies.Single(c => c.ID == Movie.ID);

                inDB.Name = Movie.Name;
                inDB.ReleaseDate = Movie.ReleaseDate;
                inDB.GenreID = Movie.GenreID;
                inDB.NumberInStock = Movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}