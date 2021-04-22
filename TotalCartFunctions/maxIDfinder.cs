using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;

namespace API.TotalCartFunctions
{
    public class maxIDfinder
    {
        public static int find()
        {
            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            

            string stm = @$"SELECT * FROM carttotals WHERE orderid = (SELECT MAX(orderid) FROM carttotals)";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();
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
