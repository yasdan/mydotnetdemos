using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopExamples
{
    class Category
    {
        int cid;
        string catdesc;
        public Category() { }
        public Category(int id, string des) {
            cid = id;
            catdesc = des;
        }
        public override string ToString()
        {
            // return base.ToString();
            return string.Format("catg Id:{0}\tCatg Name: {1}",
                cid, catdesc);
        }
    }
}
