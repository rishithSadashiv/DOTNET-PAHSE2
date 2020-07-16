using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingEFCodeFirst.Entities;
namespace HandsOnMVCUsingEFCodeFirst.Repositories
{
    public class EmployeeRepository
    {
        public EmployeeContext db = new EmployeeContext();
        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList(); //return all employee records in list format
            //return db.Employees.Where(i => i.Salary == 10000).ToList(); return multiple employees using salary
        }
        public Employee GetEmployeeById(string eid)
        {
            return db.Employees.Find(eid); //search using primary key column
          //  return db.Employees.SingleOrDefault(i => i.Eid == eid); //search with any column
        }
        public void Add(Employee e)
        {
            db.Employees.Add(e); //Add EMployee
            db.SaveChanges();
        }
        public void Delete(Employee e)
        {
            db.Employees.Remove(e); //Delete Employee
            db.SaveChanges();
        }
        public void Update(Employee e)
        {
            db.Employees.Update(e); //Update Employee
            db.SaveChanges();
        }
    }
}
