using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> list = new List<Student>()
        {
            new Student(){Sid=1,Sname="Rohan"},
            new Student(){Sid=2,Sname="Charan"}
        };
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Student> GetStudents()
        {
            return list;
        }
        [HttpGet]
        [Route("Get/{id}")]
        public Student GetById(int id)
        {
            return list.SingleOrDefault(s => s.Sid == id);
        }
        [HttpPost]
        [Route("Add")]
        public void Add(Student item)
        {
            list.Add(item);
        }

    }
}
