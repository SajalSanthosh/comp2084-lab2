using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult details(string category)
        {
            ViewBag.message = "You selected category: " + category;
            return View();
        }
    }
}
