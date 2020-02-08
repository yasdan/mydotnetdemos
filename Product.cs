using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Product
    {
        int pid;
        string pname;
        double price;
        Category ctg;
        public int Pid {
            get { return pid; }
            set { pid = value; }          
        }
        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Category Catgr
        {
            get { return ctg; }
            set { ctg = value; }
        }

        public Product() { }
        public Product(int id, string nm, double pr,Category ct)
        {
            pid = id;
            pname = nm;
            price = pr;
            ctg = ct;
        }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("ID: {0}\tName: {1}\n price:{2}",
              pid, pname, price);
        }
    }
}
