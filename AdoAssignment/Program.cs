using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//to access sql server
using System.Data;

namespace ADOdemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            SqlConnection con = new
                SqlConnection(@"initial catalog = ADOdemo ; data source = CGI-JAVA-055\CGI ;integrated security = true");

            
            //SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "t1");
            //DataTable dt = ds.Tables["t1"];
            Console.WriteLine("Enter username:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("select * from users",con);
            cmd.Parameters.Add("@p1", user);
            cmd.Parameters.Add("@p2", user);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows != true)
                Console.WriteLine("No data in the table");
            else
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1]);
                }
            }
            con.Close();
            //int cnt = cmd.ExecuteNonQuery();
            //if (cnt > 0)
            //    Console.WriteLine("Login Success");
            //else
            //    Console.WriteLine("Login Failed");

            //SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(da);
            //bool login = false;


            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        if (dr[0].ToString() == user&&dr[1].ToString()==pass)
            //        {
            //            login = true;
            //        }

            //    }

            //}
            //if (login)
            //{
            //    Console.WriteLine("Login Successfull");

            //}
            //else
            //    Console.WriteLine("Login Failed");
        }
    }
}
