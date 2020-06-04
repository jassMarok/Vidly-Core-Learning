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
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
