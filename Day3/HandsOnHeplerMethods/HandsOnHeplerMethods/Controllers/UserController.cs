using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnHeplerMethods.Models;
namespace HandsOnHeplerMethods.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
      
        public IActionResult Validate(Login login)
        {
            if(ModelState.IsValid)
            {
                //add modelt to db tables
                return RedirectToAction("Details");
            }
            else
            {
                return View("Login");
            }
            
        }
    }
}
