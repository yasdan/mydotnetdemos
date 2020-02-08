using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // provider

namespace AdonetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=LAPTOP-K1BTMIKT\SQLEXPRESS;Initial Catalog=MyDb;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string insertquery = "insert into Department(Did,Dname) values("+"'104'"+","+"'IT')";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message)
                }
            }

            //SqLserverDatredemo();
            // SQLserverDatareaderdemo();
            // LocalDbDatareader();
        }

        private static void SqLserverDatredemo()
        {
            string constr = @"Data Source=LAPTOP-K1BTMIKT\SQLEXPRESS;Initial Catalog=MyDb;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                string querystr = "Select * from Course";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader datared = cmd.ExecuteReader();
                    while (datared.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                            datared[0], datared[1], datared[2], datared[3]);
                    }
                    datared.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }

        private static void SQLserverDatareaderdemo()
        {
            string constring = @"Data Source=LAPTOP-K1BTMIKT\SQLEXPRESS;Initial Catalog=MyDb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    string querystr = "select * from Student";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(querystr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Read();
            }
        }

        private static void LocalDbDatareader()
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AbdulDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    // string querystr = "select * from Product";
                    string querystr = "select * from Student";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                Console.ReadKey();
            }
        }
    }
}
