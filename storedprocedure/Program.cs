using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storedprocedure
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"initial catalog=ADOdemo;data source=CGI-JAVA-055\CGI;integrated security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("p1",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure executed");
        }
    }
}
