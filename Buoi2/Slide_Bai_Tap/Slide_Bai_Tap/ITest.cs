using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    interface ITest
    {
        void Print();
    }
    class BaseInterface : ITest
    {
        public void Print()
        {
            Console.WriteLine("Print method called");
        }
    }
}
