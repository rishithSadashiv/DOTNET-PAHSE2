using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HandsMVCUsingComponents.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet(string name)
        {
            string ename = name;
            ViewData["un"] = ename;
            return View();
        }
        public IActionResult GetAll()
        {
            ViewBag.Flowers = new List<string>() { "Rose", "Lilly", "Jasmine" };
            return View();
        }
    }
}
