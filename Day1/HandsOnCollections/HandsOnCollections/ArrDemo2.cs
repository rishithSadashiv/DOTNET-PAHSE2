using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace HandsOnCollections
{
    class Employee
    {
        public int eid;
        public string ename;
        public double salary;
    }

    class ArrDemo2
    {
        static void Main()
        {
            Employee e1 = new Employee();
            e1.eid = 100;
            e1.ename = "Rohan";
            e1.salary = 12000;
            Employee e2 = new Employee() { eid = 101, ename = "Karan", salary = 13000 };
            Employee e3 = new Employee() { eid = 102, ename = "Ram", salary = 13000 };
            ArrayList list = new ArrayList() { e2, e3 };
            list.Add(e1);
            list.Add(new Employee() { eid = 104, ename = "Suren", salary = 14000 });
            list.Add(10);
            //foreach(Employee e in list)
            //{
            //    Console.WriteLine("{0} {1} {2}", e.eid, e.ename, e.salary);
            //}
            foreach (object e in list)
            {
                // Console.WriteLine("{0} {1} {2}", e.eid, e.ename, e.salary);
                Console.WriteLine(e);
            }
            foreach (var e in list)
            {
                // Console.WriteLine("{0} {1} {2}", e.eid, e.ename, e.salary);
                Console.WriteLine(e);
            }


        }
    }
}
