using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Rectangle : IMix
    { 
    
        public void area(int a)
        {
            Console.WriteLine("{0}", a);
        }
       public void area(int b,int a)
        {
            Console.WriteLine("Rectangle area :{0}", a * b);
        }
    }
}
