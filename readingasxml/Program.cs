using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace readingasxml
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = @"initial catalog = ADOdemo ; data source = CGI-JAVA-055\CGI ;integrated security = true";
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("select * from users",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "t1");
            string data = ds.GetXml();
            Console.WriteLine(data);

        }
    }
}
