using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4._1.Controllers
{
    public class extraController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //if you do not put a parameter in the view() function, it will default to the index file
            //--this is because the index view is associated with this the iActionResult
        }
        //public IActionResult Yadda()
        //{

        //}
    }
}
