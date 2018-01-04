using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //return View(movie);
            //return Content("Hello World");
            return StatusCode(404);
            //return RedirectToAction("Index", "Home");
        }
    }
}
