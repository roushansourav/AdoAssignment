using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"data source=CGI-JAVA-055\CGI;initial catalog=ADOdemo;integrated security=true");
            con.Open();
            Console.WriteLine("Enter eid: ");
            string eid = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select * from Employee where eid=@p1",con);
            cmd.Parameters.Add("@p1", eid);
            SqlDataReader reader= cmd.ExecuteReader();
            if (reader.HasRows != true)
                Console.WriteLine("Eid doesnot Exist");
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
                }
            }
            con.Close();
        }
    }
}
