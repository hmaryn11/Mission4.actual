using Microsoft.AspNetCore.Mvc;
using Mission41.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission41.Controllers
{
    public class extraController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //if you do not put a parameter in the view() function, it will default to the index file
            //--this is because the index view is associated with this the iActionResult
        }
        [HttpGet]
        public IActionResult GradeCalc()
        {
            //this creates an action to go to the new GradeCalc View
            return View();
        }
        //add "object model to show that these are two diff methods
        [HttpPost] //attatch this attributes to the mehtod
        public IActionResult GradeCalc(GradeCalcModel model)
        {
            //this creates an action to go to the new GradeCalc View
            return View();
        }
}
}
