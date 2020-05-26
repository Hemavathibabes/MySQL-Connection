using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace Dbconnection
{
    class Program
    {
        static void Main(string[] args)
        {



            MySqlConnection con = new MySqlConnection("server =localhost; user id =root; database =sampledb; password =Hemabanu2* ");
            MySqlCommand cmd;
            MySqlDataReader dr;
            
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Students";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               int id = (int)dr["s_id"];
                String name = (string)dr["s_name"];
                String bg = (string)dr["s_bloodgroup"];
                String city = (string)dr["city"];
                Console.WriteLine("{0}  {1}  {2}  {3}", id, name,bg,city);
              
            }
         




        }
    }
}
