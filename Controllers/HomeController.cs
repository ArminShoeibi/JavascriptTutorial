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

        // console Object
        public IActionResult Lesson1() => View();

        // Variables
        public IActionResult Lesson2() => View();


        // Primitive Types
        public IActionResult Lesson3() => View();


        // Object Literal
        public IActionResult Lesson4() => View();

        // Arrays
        public IActionResult Lesson5() => View();

        // Functions
        public IActionResult Lesson6() => View();


        // Operators
        public IActionResult Lesson7() => View();

    }
}
