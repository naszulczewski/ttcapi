using System;
using API.Cartfunctions;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data;
using API;
using System.Linq;
using API.Cartfunctions.getCart;

namespace ttcapi.TotalCartFunctions
{
    public class postCartTotal
    {
        public void postCartTotalData(int OrderID)
        {
            readData getAllItems = new readData();
            List<cart> allItems = getAllItems.GetAllItems();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            foreach(cart mI in allItems)
            {
                string stm = "INSERT INTO carttotals(OrderID, itemName, price, quantity ) VALUES(@OrderID, @itemName, @price, @quantity)";
                using var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                cmd.Parameters.AddWithValue("@itemName", allItems.ElementAt(1));
                cmd.Parameters.AddWithValue("@quantity", allItems.ElementAt(3));
                cmd.Parameters.AddWithValue("@price", allItems.ElementAt(2));
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }
}