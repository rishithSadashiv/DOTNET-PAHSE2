using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    //delegate declaration
    public delegate void Mydelegate();
    public delegate void Greetdelegate(string n);
    class Program
    {
        public void Task()
        {
            Console.WriteLine("Task Running..");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //instantiate delegates
            Mydelegate mydelegate = new Mydelegate(obj.Task);
            //invoke delegate
            mydelegate();
            Greetdelegate greetdelegate = new Greetdelegate(obj.Greet);
            greetdelegate("Sachin");
            Console.ReadKey();
        }
    }
}
