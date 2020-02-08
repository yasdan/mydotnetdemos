using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace oopExamples
{
    class Program
    {
        
      

       // ArrayList alist = new ArrayList();
        static void Main(string[] args)
        {
            //ListDemo();
            // SortedlistDemo();

            //QueDemo();

            //StackDemo();
            // Hashtabledemo();

            //ArrayListDemo();
            // Sortarray();
            // SplitDelmiterdemo();
            // JoinMethod();
            // stringConcatmethod();

            //  StringSplitmethod();


            // stringBuildemo();

            // stringexamples();
            // InterfaceDemo();

            //abstractdemo();
            // constructrAggregation();
            // OverideAgregation();
            // AgrigateOverridemo();
        }

        private static void ListDemo()
        {
            List<string> stlst = new List<string>();
            stlst.Add("programing languges:");
            stlst.Add("C#");
            stlst.Add("VB");
            stlst.Add("F#");
            stlst.Add("Python");
            stlst.Add("PhP");
            stlst.Add("Java");
            foreach (string itm in stlst)
            {
                Console.WriteLine(itm);
            }
            stlst.Insert(3, "R");
            Console.WriteLine();
            foreach (string itm in stlst)
            {
                Console.WriteLine(itm);
            }
        }

        private static void SortedlistDemo()
        {
            SortedList slist = new SortedList();
            slist.Add("Zameer", 234);
            slist.Add("Anand", 123);
            slist.Add("Krish", 213);
            slist.Add("Bhim", 678);
            foreach (string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (int v in slist.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void QueDemo()
        {
            Queue qu = new Queue();
            qu.Enqueue(123);
            qu.Enqueue(234);
            qu.Enqueue(432);
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
            qu.Dequeue();
            Console.WriteLine();
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
        }

        private static void StackDemo()
        {
            Stack stk = new Stack();
            stk.Push("Chocolate");
            stk.Push("Buiscuit");
            stk.Push("Cake");
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            stk.Pop();
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
        }

        private static void Hashtabledemo()
        {
            Hashtable hst = new Hashtable();
            hst.Add("Raju", "12354");
            hst.Add("Vimala", "5678");
            hst.Add("Karan", "76552");
            foreach (string k in hst.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
            }
            hst.Remove("karan");
            foreach (string k in hst.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
            }
        }

        private static void ArrayListDemo()
        {
            ArrayList al = new ArrayList()
           {"Amma","Raj","Munna","Krish","Sajid","Chandu" };
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            al.Add("Bharat");
            al.Add("Sreeja");
            al.Insert(4, "Sharuq");
            Console.WriteLine();

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            Console.WriteLine();

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "Cat", "Mat" };
            al.SetRange(4, r);
            Console.WriteLine();

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);
            Console.WriteLine();

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
        }

        private static void Sortarray()
        {
            int[] myar = new int[] { 34, 12, 56, 43, 19, 8, 51, 78, 10 };
            Console.WriteLine("\nArray elements are..\n");
            foreach (int i in myar)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("\nArray elements after sorting..");
            Array.Sort(myar);
            foreach (int i in myar)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("\nArray elements after reverse..");
            Array.Reverse(myar);
            foreach (int i in myar)
            {
                Console.Write(" {0} ", i);
            }
        }

        private static void SplitDelmiterdemo()
        {
            string strlong = "Hello how are you? I am fine, What about you?";
            string[] sts = strlong.Split('?', ',');

           /* string[] slt = strlong.Split();
            int cn = slt.Count();
            int ln = 3;
            Array.Copy();*/
            foreach (string st in sts)
            {
                Console.WriteLine(st);
            }
           List<string>sl= sts.ToList();
           Console.WriteLine("list count is {0}", sl.Count());

        }

        private static void JoinMethod()
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] ary = new string[size];
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("Enter  word {0}", i + 1);
                ary[i] = Console.ReadLine();
            }

            Console.WriteLine(JoinstrArray(ary));
        }

        private static void stringConcatmethod()
        {
            Console.WriteLine("Enter first name");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string ln = Console.ReadLine();
            Console.WriteLine(Fullname(fn, ln));
        }

        private static void StringSplitmethod()
        {
            Console.WriteLine("Type a long statement");
            string statement = Console.ReadLine();
            string[] sts = Splitstr(statement);
            foreach (string s in sts)
            {
                Console.WriteLine(s);
            }
        }
         
        static string[] Splitstr(string st)
        {
            return st.Split();
        }
        static string Fullname(string firstname, string lastname)
        {
            return String.Concat(firstname, " ", lastname);
        }
        static string JoinstrArray(string[] ar)
        {
            return String.Join(" ",ar);
        }
        private static void stringBuildemo()
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);
            stb.Append(234454562);
            Console.WriteLine("Appended long values {0}", stb);
            int i = stb.Capacity;
            Console.WriteLine("Initial capacity of stringBuilder is {0}",
                i);
            stb.Insert(6, " World");
            Console.WriteLine("inserted at 6 is {0}", stb);
            stb.Remove(7, 4);
            Console.WriteLine("After removing {0}", stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("After replacing {0}", stb);
            stb.Clear();
            Console.WriteLine("After clear {0}", stb);
        }

        private static void stringexamples()
        {
            string data = "Hello world";
            Console.WriteLine(data);
            string a = data.Insert(6, "My ");
            string bn = " You are so nice.";

            Console.WriteLine(a);
            Console.WriteLine(String.Concat(a, bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "Anand", "Raju", "Munna" };
            foreach (string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to the C#";
            String[] words = st1.Split();
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is {0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index of is {0}", i);

            int l = st1.Length;
            Console.WriteLine("length of the string is {0}", l);
            words.Reverse();

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }

            int nx = string.Compare("hello", "hello");
            Console.WriteLine("Comparison is {0}", nx);
        }

        private static void dateComingdate()
        {
            DateDemo dt = new DateDemo();
            Console.WriteLine("Coming date is {0}", dt.GetDate());
        }

        private static void joindatedemo()
        {
            DateDemo dt = new DateDemo();
            Console.WriteLine("Enter Name");
            dt.name = Console.ReadLine();
            Console.WriteLine("Enter join date");
            dt.Dte = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("you joined {0} months ago", dt.GetMonth());
        }

        private static void ExeptionDemo()
        {
            int d = 0;
            try
            {
                Console.WriteLine("Enter a number");
                int no1 = Convert.ToInt32(Console.ReadLine());
                if (no1 <= 0)
                {
                    throw new Exception("value must be > 0");
                }
                Console.WriteLine("Enter second number");
                int no2 = Convert.ToInt32(Console.ReadLine());
                d = no1 / no2;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (NullReferenceException re)
            {
                Console.WriteLine(re.Message);
            }
            catch (InvalidCastException ics)
            {
                Console.WriteLine(ics.Message);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Quotient is {0}", d);
            }
        }

        private static void Dateexample()
        {
            DateDemo dt = new DateDemo();
            Console.WriteLine("Enter Name");
            dt.name = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            dt.Dte = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("{0} years", dt.GetAge());
        }

        private static void InterfaceDemo()
        {
            Square sq = new Square();
            sq.area(5);
            Rectangle rc = new Rectangle();
            rc.area(20, 12);
        }

        private static void abstractdemo()
        {
            Sweet sw = new Sweet();
            sw.Show();
            Console.WriteLine(sw.showItem("Laddu"));
        }

        private static void constructrAggregation()
        {
            Category ct = new Category(1, "Toys");
            Product pd = new Product(101, "Barbie doll", 450, ct);
            Console.WriteLine(pd.ToString());
            Console.WriteLine(ct.ToString());
        }

        private static void OverideAgregation()
        {
            Customer cst = new Customer
            {
                Cid = 234,
                Name = "Adnan",
                Address = "Hyderabad",
                Fxacnt = new FixedAccount
                {
                    AccountNo = 5678,
                    Balance = 10000
                }
            };
            Console.WriteLine("Cid: {0}\tName: {1}\n Adress: {2}\n Account No:{3}\tBALANCE:{4}",
                cst.Cid, cst.Name, cst.Address,
                cst.Fxacnt.AccountNo, cst.Fxacnt.Balance);
            Console.WriteLine("Fixed interest{0}", cst.Fxacnt.InterestAmount(9.6, 2));

            Customer cst1 = new Customer
            {
                Cid = 333,
                Name = "Chandu",
                Address = "Chennai",
                Bnkact = new BankAccount
                {
                    AccountNo = 9878,
                    Balance = 10000
                }
            };
            Console.WriteLine("\nCid: {0}\tName: {1}\n Adress: {2}\n Account No:{3}\tBALANCE:{4}",
                cst1.Cid, cst1.Name, cst1.Address,
                cst1.Bnkact.AccountNo, cst1.Bnkact.Balance);
            Console.WriteLine("Simple interest{0}", cst1.Bnkact.InterestAmount(9.6, 2));
        }

        private static void AgrigateOverridemo()
        {
            Employee emp = new Employee
            {
                EmpId = 101,
                Name = "Anand",
                Dept = new Department { DeptId = 1, DeptName = "production" }
            };

            Console.WriteLine("{0}\t{1}", emp.EmpId, emp.Name);
            Console.WriteLine("{0}\t{1}", emp.Dept.DeptId, emp.Dept.DeptName);
            Console.WriteLine("Salry is {0}", emp.empSalary(34000));

            Analyst al = new Analyst
            {
                EmpId = 323,
                Name = "Vijaya",
                Dept = new Department
                {
                    DeptId = 3,
                    DeptName = "Content Development"
                }
            };
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", al.EmpId,
             al.Name, al.Dept.DeptId, al.Dept.DeptName);
            Console.WriteLine(al.empSalary(34000));
        }
    }
}
