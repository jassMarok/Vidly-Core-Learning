using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly VidlyDbContext _context;

        public MoviesController(VidlyDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult New()
        {
            var genres = _context.Genre.ToList();

            var model = new MovieFormViewModel
            {
                Genre = genres,
                Movie = new Movie()
            };

            ViewBag.Title = "Add Movie";

            return View("MovieForm", model);
        }

        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var model = new MovieFormViewModel
            {
                Genre = _context.Genre.ToList(),
                Movie = movie
            };

            ViewBag.Title = "Edit Movie";
            return View("MovieForm", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}
