using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }

    }

    class Demo1
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Salary=10000},
                new Employee(){Eid=2,Ename="Karan",Salary=12000},
                new Employee(){Eid=4,Ename="Monica",Salary=15000},
            };
            //Get All Employees
            var r = from e in list select e;
            var r1 = from e in list select new { e.Eid, e.Ename };
            var r2 = from e in list where e.Eid == 1 select e;
            var r3 = from e in list where e.Salary > 10000 select e;
            var r4 = from e in list where e.Ename == "Karan" && e.Salary == 10000 select e;
            //Liqn with Query Methods
            var r11 = list.Select(i => i); //returns all //deferred execution
            List<Employee> l1 = list.Where(i => i.Salary > 10000).ToList(); //immidiate execution
            Employee e1 = list.Where(i => i.Eid == 1).SingleOrDefault();
            Employee e2 = list.Single(i => i.Ename == "Rohan");
        }
    }
}
