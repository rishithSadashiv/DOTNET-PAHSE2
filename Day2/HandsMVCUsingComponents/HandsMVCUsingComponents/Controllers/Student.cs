using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsMVCUsingComponents.Models;
namespace HandsMVCUsingComponents.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> list = new List<Student>()
        {
            new Student() { Sid = 1, Sname = "Rohan", Age = 10 },
             new Student() { Sid = 2, Sname = "David", Age = 10 },
              new Student() { Sid = 3, Sname = "Raj", Age = 10 },
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int uid)
        {
            // Student s = new Student() { Sid = 1, Sname = "Rohan", Age = 10 };
            Student s = list.SingleOrDefault(i => i.Sid == uid);
            return View(s);
        }
        public IActionResult GetAll()
        {
            return View(list);
        }
    }
}
