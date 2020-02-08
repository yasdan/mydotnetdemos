using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class DateDemo
    {
       public string name { get; set; }
       public DateTime Dte { get; set; }
      public int GetAge()
        {
            TimeSpan age = DateTime.Today-Dte;
            double a= age.TotalDays/365;
            return Convert.ToInt32(a);
        }
      public int GetMonth()
        {
            TimeSpan duration = DateTime.Today - Dte;
            double d = duration.TotalDays / 30;
            return Convert.ToInt32(d);
        }

    public string GetDate()
        {
            Console.WriteLine("Enter no of days");
            int da = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Today.AddDays(da);
           DateTime dyt=  DateTime.Today.AddYears(da);
           TimeSpan td = DateTime.Today.Subtract(dt);
            return string.Format("{0}\t{1}\tDifference {2}",dt,dyt,td);
        }
    }
}
