using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;
using MySql.Data.MySqlClient;

namespace API.TotalCartFunctions
{
    public class maxIDfinder
    {
        public static int find()
        {
            // string cs = @"URI=file:../carttotals.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @$"SELECT * FROM OrderIDTable WHERE OrderID = (SELECT MAX(OrderID) FROM OrderIDTable)";

            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();
            int orderID = 0;
            while(rdr.Read())
            {
                orderID = rdr.GetInt32(0);
            }
            Console.WriteLine(orderID);
            return orderID;
        }
    }
}
