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

        // Control Flow if...else
        public IActionResult Lesson8() => View();

        // Control Flow switch
        public IActionResult Lesson9() => View();

        // Control Flow for loop
        public IActionResult Lesson10() => View();

        // Control Flow while loop
        public IActionResult Lesson11() => View();

        // Control Flow do...while loop
        public IActionResult Lesson12() => View();

        // Control Flow for...in
        public IActionResult Lesson13() => View();

        // Control Flow for...of (ES2015)
        public IActionResult Lesson14() => View();

        // Break and Continue
        public IActionResult Lesson15() => View();
    }


}
