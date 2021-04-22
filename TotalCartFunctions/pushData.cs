using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using MySql.Data.MySqlClient;
using MySql.Data;
using API;
using API.Cartfunctions;


namespace API.TotalCartFunctions
{
    public class pushData
    {
        public void pushCartData(cart value)
        {
            // string cs = @"URI=file:../carttotals.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            int id = maxIDfinder.find();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO carttotals(OrderID, itemName, price, quantity) VALUES(@OrderID, @itemName, @price, @quantity)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@OrderID", id);
            cmd.Parameters.AddWithValue("@itemName", value.itemName);
            cmd.Parameters.AddWithValue("@price", value.price);
            cmd.Parameters.AddWithValue("@quantity", value.quantity);

            // cmd.CommandText = @"INSERT INTO carttotals(totalprice, qckparm, qccc, qvegb, qcss, qturk, qhouse, pckparm, pccc, pvegb, pcss, pturk, phouse) VALUES(@totalprice, @qckparm, @qccc, @qvegb, @qcss, @qturk, @qhouse, @pckparm, @pccc, @pvegb, @pcss, @pturk, @phouse)";
            // cmd.Parameters.AddWithValue("@totalprice", 0.0);
            // cmd.Parameters.AddWithValue("@qckparm", 0);
            // cmd.Parameters.AddWithValue("@qccc", 0);
            // cmd.Parameters.AddWithValue("@qvegb", 0);
            // cmd.Parameters.AddWithValue("@qcss", 0);
            // cmd.Parameters.AddWithValue("@qturk", 0);
            // cmd.Parameters.AddWithValue("@qhouse", 0);
            // cmd.Parameters.AddWithValue("@pckparm", 0.0);
            // cmd.Parameters.AddWithValue("@pccc", 0.0);
            // cmd.Parameters.AddWithValue("@pvegb", 0.0);
            // cmd.Parameters.AddWithValue("@pcss", 0.0);
            // cmd.Parameters.AddWithValue("@pturk", 0.0);
            // cmd.Parameters.AddWithValue("@phouse", 0.0);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Console.WriteLine("made it to the pushData");
        }
    }
}