using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Customer
    {
        public int Cid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public BankAccount Bnkact { get; set; }
        public FixedAccount Fxacnt { get; set; }
    }
}
