using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("in base constructor");
        }

        public virtual void Method1()
        {
            Console.WriteLine("in base.method1");
        }

        public void Method2()
        {
            Console.WriteLine("Base.Method2()");
        }
    }
}
