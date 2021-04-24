using System;
using System.Collections.Generic;
using API;
using API.Cartfunctions;
using API.TotalCartFunctions;
using MySql.Data.MySqlClient;
using ttcapi;

namespace ttcapi.TotalCartFunctions
{
    public class putCartTotals
    {
        public void putCartTotalsData(List<cart> totalCart)
        {
            Console.WriteLine("made it to the put cart totals data");

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // maxIDfinder maxID = new maxIDfinder();
            int OrderID = maxIDfinder.find();

            foreach(cart item in totalCart)
            {

                string stm = "INSERT INTO carttotals(OrderID, itemName, price, quantity ) VALUES(@OrderID, @itemName, @price, @quantity)";
                using var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                cmd.Parameters.AddWithValue("@itemName", item.itemName);
                cmd.Parameters.AddWithValue("@quantity", item.quantity);
                cmd.Parameters.AddWithValue("@price", item.price);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }
}