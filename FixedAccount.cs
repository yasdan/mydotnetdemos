using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class FixedAccount :BankAccount
    {
        public override string InterestAmount(double rate, int time)
        {
            double intrestamt = (Balance * rate * time) / 100;
            double fixintamt = intrestamt * 3 / 100;
            double amt = intrestamt + fixintamt;
            return amt.ToString();
        }
    }
}
