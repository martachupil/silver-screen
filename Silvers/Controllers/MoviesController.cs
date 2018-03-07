using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Silvers.Models;

namespace Silvers.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shape of water" };
            return View(movie);
        }
    }
}