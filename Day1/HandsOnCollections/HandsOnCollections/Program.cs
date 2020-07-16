using System;
using System.Collections;
namespace HandsOnCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");
            //ArrayList list = new ArrayList();
            ////add items to arraylist
            //list.Add(10);
            //list.Add("Rohan");
            //list.Add("II");
            //list.Add(20.4);
            //list.Add("Rohan");
            //list.Add(new DateTime(2000, 10, 21));
            //int age = (int)list[0];
            //string name = list[1].ToString();
            //Console.WriteLine("Size: " + list.Count);
            //list.Add("Suren");
            //Console.WriteLine("Size: " + list.Count);
            ////Remove item
            ////list.Remove("Rohan");
            //list.RemoveAt(4);
            //Console.WriteLine("Size: " + list.Count);
            //foreach (object o in list)
            //    Console.WriteLine(o);

            //Stack obj = new Stack();
            //obj.Push(10);
            //obj.Push(12);
            //obj.Push(13);
            //obj.Push(34);
            //obj.Pop();
            //foreach (var k in obj)
            //    Console.WriteLine(k);
            Queue obj = new Queue();
            obj.Enqueue('a');
            obj.Enqueue('o');
            obj.Enqueue('i');
            obj.Enqueue('1');
            obj.Enqueue('4');
            Console.WriteLine(obj.Peek()); //returns 1st item
            obj.Dequeue(); //remove 1st item;
            Console.WriteLine();

            foreach (var k in obj)
                Console.WriteLine(k);
           


        }
    }
}
