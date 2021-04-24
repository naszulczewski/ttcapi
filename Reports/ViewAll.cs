using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data;
using API;

namespace API.Reports
{
    public class ViewAll
    {
        public List<cart> ViewAllReports()
        {
            Console.WriteLine("made it to viewallreports");
            List<cart> cartTotals = new List<cart>();

            // string cs = @"URI=file:../carttotals.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM carttotals";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){OrderID = rdr.GetInt32(1), itemName = rdr.GetString(2), price = rdr.GetFloat(3), quantity = rdr.GetInt32(4)};
                cartTotals.Add(temp);
            }

            return cartTotals;
        }
    }
}