﻿using System;
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
            Console.WriteLine("Enter user details:(username,password,age,city)");
            string str = Console.ReadLine();
            string[] input = str.Split(',');
            SqlCommand cmd = new SqlCommand("p2",con);
            cmd.Parameters.AddWithValue("@p1", input[0]);
            cmd.Parameters.AddWithValue("@p2", input[1]);
            cmd.Parameters.AddWithValue("@p3", int.Parse(input[2]));
            cmd.Parameters.AddWithValue("@p4", input[3]);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure executed");
        }
    }
}
