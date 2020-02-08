using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class BankAccount
    {
        public int AccountNo { get; set; }
        public double Balance { get; set; }

        public virtual string InterestAmount(double rate, int time)
        {
            double intrestamt = (Balance * rate * time) / 100;
            return intrestamt.ToString();
        }
    }
}
