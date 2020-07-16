using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 43, 42, 54, 56, 67, 76, 79, 98, 87, 76, 21 };
            //fetch only even values
            var res = from i in a where i % 2 == 0 select i;
            var res1 = from i in a
                       where i % 2 != 0 && i > 50
                       select i;
            var res2 = from i in a
                       where i > 40
                       orderby i ascending
                       select i;
            foreach (var k in res1)
                Console.WriteLine(k);

        }
    }
}
