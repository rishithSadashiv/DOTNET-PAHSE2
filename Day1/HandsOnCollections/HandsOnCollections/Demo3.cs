using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace HandsOnCollections
{
    class Demo3
    {
        static void Main()
        {
            //Hashtable table = new Hashtable();
            //table.Add(1000, "Rohan");
            //table.Add(1001, "Suren");
            //table.Add(1002, "Ram");
            //table.Add(1003, "Monica");
            //table.Add('c', "Cat");
            //string name = table[1001].ToString();
            //Console.WriteLine(name);
            //foreach(var k in table.Keys)
            //{
            //    Console.WriteLine("Key:{0} Value:{1}", k, table[k]);
            //}
            SortedList logins = new SortedList();
            logins.Add("Rohan", "12345");
            logins.Add("Suren", "12345");
            logins.Add("Jeson", "12345");
            logins.Add("Karan", "12345");
            foreach(var k in logins.Keys)
            {
                Console.WriteLine("{0} {1}", k, logins[k]);
            }
            Console.WriteLine("Enter Username");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();
            bool flag = false;
            foreach(var item in logins.Keys)
            {
                if(item.ToString()==uname && pwd==logins[item].ToString())
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("Invalid User");
        }
    }
}
