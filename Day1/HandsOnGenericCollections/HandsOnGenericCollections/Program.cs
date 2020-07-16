using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int sid;
        public string sname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 23, 34, 56, 78 };
            int no = list[3];
            List<string> list1 = new List<string>() { "Rohan", "Karan", "Jeson" };
            list1.Add("Monica");
            List<Student> list2 = new List<Student>()
            {
                new Student(){sid=1,sname="Karan"},
                 new Student(){sid=2,sname="Suren"},
                  new Student(){sid=3,sname="Suresh"},
                   new Student(){sid=4,sname="Monica"},
                    new Student(){sid=5,sname="Bindu"},
            };
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            bool flag = false;
            foreach (Student s in list2)
            {
                if (s.sid == id)
                {
                    Console.WriteLine("{0} {1}", s.sid, s.sname);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("Invalid Id");

        }
    }
}
