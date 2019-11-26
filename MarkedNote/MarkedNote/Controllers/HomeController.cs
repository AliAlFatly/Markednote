using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarkedNote.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("editNote/{id}")]
        public IActionResult editNote([FromRoute] int id)
        {
            ViewBag.id = id;
            return View();
        }

        [Route("newNote")]
        public IActionResult newNote()
        {
            return View();
        }

        
    }
}