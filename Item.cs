using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
   abstract class Item
    {
        public abstract string showItem(string itm);
        public void Show()
        {
            Console.WriteLine("Non abstract method ");
        }

    }
}
