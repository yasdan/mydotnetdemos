using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritanceDemo();

            operatoroverlodingDemo();

            // staticdatamethod();
            //staticdemo();
            /* Program prg = new Program();
             prg.Nonstaticmethod();*/


            // MethodOverloadingDemo();
            // AutomaticPropertiesDemo();
            //TimeObjMethod();

            // studentObjmethod();
            // geTrObj();

            // get2ndTrObj();
            // get3rdTrObj();
            // CarObjmethod();


        }

        private static void operatoroverlodingDemo()
        {
            Demo d1 = new Demo(20, 50);
            d1.showData();
            Demo d2 = new Demo(500, 100);
            d2.showData();
            Demo s = new Demo();
            s = d1 + d2;
            s.showData();
            Demo d = new Demo();
            d = d1 - d2;
            d.showData();
        }

        private static void inheritanceDemo()
        {
            RoadwayVehicle rv = new RoadwayVehicle();
            rv.ShowVehicle();
            rv.Show();
            Train tr = new Train();
            tr.showTrain();
            tr.Show();
            tr.ShowVehicle();
            Ship sp = new Ship();
            sp.ShowShip();
            sp.ShowVehicle();
        }

        private static void staticdatamethod()
        {
            Sample sp = new Sample();
            Sample s1 = new Sample();
            Sample s2 = new Sample();
            Sample.Show();
        }

        private static void staticdemo()
        {
            Sales sl = new Sales();
            sl.Prdname = "Cake";
            sl.Qntity = 3;
            sl.Price = 125;
            Console.WriteLine("{0}\t {1}", sl.Prdname, sl.Qntity);
            Console.WriteLine(sl.Saleamount);
            Console.WriteLine(sl.TotalAmount);
            Sales s2 = new Sales();
            s2.Prdname = "Ice Cream";
            s2.Price = 200;
            s2.Qntity = 5;
            Console.WriteLine("{0}\t {1}", s2.Prdname, s2.Qntity);
            Console.WriteLine(s2.Saleamount);
            Console.WriteLine(s2.TotalAmount);
        }

        public void Nonstaticmethod()
        {
            Console.WriteLine("It is a non static method");
        }

        private static void MethodOverloadingDemo()
        {
            Calculate clt = new Calculate();
            Console.WriteLine(clt.area(12));
            Console.WriteLine(clt.area(10, 20));
            Console.WriteLine(clt.area(15.7));
            Console.WriteLine(clt.area(10.6, 9));
        }

        private static void AutomaticPropertiesDemo()
        {
            Product pd = new Product
            {
                Id = 1,
                Pname = "Chocolate",
                Price = 100
            };
            Console.WriteLine("{0}\n{1}\n{2}", pd.Id,
                pd.Pname, pd.Price);
        }

        private static void TimeObjMethod()
        {
            TimePeriod tp = new TimePeriod();
            tp.Hours = 15;
            Console.WriteLine("hourse: {0}", tp.Hours);
            tp.showSeconds();
        }

        private static void CarObjmethod()
        { 
            // Car mycar = new Car();
            Car mycar1 = new Car("AP16TS8987");
            Car mycar = new Car("AP16TS8987", "Desire", "Grey", 456000);
            Console.WriteLine(mycar.showCar());
            string data = mycar1.showCar();
            Console.WriteLine(data);
        }

        private static void studentObjmethod()
        {
            Student std = new Student("Sunder", "Raju");
            // std.Name = "Aman";
            std.Idno = 123;
            std.Course = "C#";
            // std.JoinDate = DateTime.Parse("20-01-2020");
            std.JoinDate = Convert.ToDateTime("20-01-2020");
            Console.WriteLine("name is {0}\n ID is {1}",
                std.Name, std.Idno);
            Console.WriteLine("Course: {0}\n Joining date:{1}",
                std.Course, std.JoinDate.ToShortDateString());
        }

        private static void get3rdTrObj()
        {
            Trainee tr2 = new Trainee();
            tr2.Getdata("Salman", "432", "Chennai", 21);
            //tr2.age = 12;
            tr2.ShowData();
        }

        private static void get2ndTrObj()
        {
            Trainee tr1 = new Trainee();
            Console.WriteLine();
            tr1.Getdata("Supraja", "234", "Chennai", 21);
            tr1.ShowData();
        }

        private static void geTrObj()
        {
            // object  of Trainee class
            Trainee tr = new Trainee();
            tr.Getdata("Saravanan", "EMp0002", "Chennai", 21);
           Console.WriteLine( tr.ShowData());
        }
    }
}
