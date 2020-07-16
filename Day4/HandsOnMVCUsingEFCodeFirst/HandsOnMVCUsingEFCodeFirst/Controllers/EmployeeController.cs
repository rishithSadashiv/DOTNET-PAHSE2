using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingEFCodeFirst.Entities;
using HandsOnMVCUsingEFCodeFirst.Repositories;
namespace HandsOnMVCUsingEFCodeFirst.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository _repo = new EmployeeRepository();
        // GET: EmployeeController
        [Route("GetAll")]
        public ActionResult Index() //show all employees
        {
            List<Employee> list = _repo.GetEmployees();
            return View(list);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(string id)
        {
            Employee e = _repo.GetEmployeeById(id);
            return View(e);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(item);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(string id)
        {
            Employee e = _repo.GetEmployeeById(id);
            return View(e);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee item)
        {
            try
            {
                _repo.Update(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(string id)
        {
            Employee e = _repo.GetEmployeeById(id);
            return View(e);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee item)
        {
            try
            {
                _repo.Delete(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
