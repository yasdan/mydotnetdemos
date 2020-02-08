using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Square : IMix
    {
        public void area(int a)
        {
            Console.WriteLine("Area of square :{0}", a * a);
        }
    }
}
