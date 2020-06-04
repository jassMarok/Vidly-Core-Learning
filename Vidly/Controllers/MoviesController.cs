using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> movies = new List<Movie>
        {
            new Movie {Id = 1, Name = "Shareek"},
            new Movie {Id = 2, Name = "War"}
        };

        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
