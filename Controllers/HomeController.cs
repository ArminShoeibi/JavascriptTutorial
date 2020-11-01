using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JavascriptTutorial.Controllers
{
    /// <summary>
    /// Javascript Tutorial
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //console Object
        public IActionResult Lesson1() => View();
    }
}
