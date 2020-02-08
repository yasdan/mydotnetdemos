using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 namespace OopsDemos
{
    class Car
    {
        string regno;
        string model;
        string color;
        double price;

       public Car() { } //default constructor
        public Car(string reg) //overloaded 
        {
            regno = reg;
        }
        public Car(string reg, string mod)
        {
            regno = reg;
            model = mod;
        }
        public Car(string reg,string mod, string colr, double pr)
        {
            regno = reg;
            model = mod;
            color = colr;
            price = pr;
        }
       // public void showCar()
       public string showCar()
        {
            return string.Format("Reg no:{0}\nMoel is {1}\nColor:{2}\nPrice:{3}",
               regno ,model,color,price );
           /* Console.WriteLine("Reg No is " + regno);
            Console.WriteLine("Model is {0}", model);
            Console.WriteLine("Colour is {0} and price is {1}",
                color, price);*/
        }
    }
}
