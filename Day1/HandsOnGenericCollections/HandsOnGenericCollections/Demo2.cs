using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Demo2
    {
        static void Main()
        {
            Stack<string> list1 = new Stack<string>();
            list1.Push("Rohan");
            list1.Push("Suren");
            Queue<double> list2 = new Queue<double>();
            list2.Enqueue(12.3);
            list2.Enqueue(23.3);
        }
    }
}
