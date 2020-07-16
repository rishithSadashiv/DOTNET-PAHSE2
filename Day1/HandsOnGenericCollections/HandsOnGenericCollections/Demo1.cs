using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Demo1
    {
        static void Main()
        {
            Dictionary<int, string> list1 = new Dictionary<int, string>();
            Dictionary<char, int> list2 = new Dictionary<char, int>();
            list1.Add(100, "Rohan");
            list1.Add(102, "David");
            list2.Add('a', 90);
            list2.Add('A', 65);
            string name = list1[100];
            foreach(int k in list1.Keys)
            {
                Console.WriteLine("{0} {1}", k, list1[k]);
            }
        }
    }
}
