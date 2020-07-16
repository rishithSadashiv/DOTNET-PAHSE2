using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void Delegate1();
    class Demo
    {
        public void Task()
        {

        }
        public void Doit(Delegate1 d)
        {
            d();//invoke delegate
        }
        static void Main()
        {
            Demo obj = new Demo();
            obj.Doit(obj.Task);
        }
    }
}
