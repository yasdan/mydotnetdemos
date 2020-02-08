using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public  Department Dept { get; set; }

        public virtual string empSalary(double sal)
        {
            return sal.ToString();
        }
    }
}
