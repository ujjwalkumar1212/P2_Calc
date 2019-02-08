using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;


namespace Web.Controllers
{
    public class New : Controller
    {
        public IActionResult Index()
        {
            var Rice = new Food { foodName = "Rice" };
            return View(Rice);
        }

        public IActionResult TextOutput()
        {
            return Content("The Food was awesome!");
        }

        public IActionResult JsonOutput()
        {
            return Json(new
            {
                foodName = "Sandwich",
                foodPrice = 5.23
            });
        }

        public IActionResult HTMLOutput()
        {
            return Content("<!DOCTYPE html><html><body>I liked Food</body></html>", "text/html");
        }

        public IActionResult ViewOutput()
        {
            var Food = new Food { foodName = "Sandwich" };
            return View(Food);
        }
    }
}