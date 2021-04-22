using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TTCatering.Cartfunctions.updateCart
{
    public class saveData : iPostCart
    {
        public void UpdateCart(string value, double price)
        {
            // string cs = @"URI=file:../cart.db"; // make this a static class!!
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine("I made it to the price and it is " + price);
            

            // cmd.CommandText = @"INSERT INTO cart(itemName, quantity, price) VALUES(@itemName, @quantity, @price)";
            string stm = @"INSERT INTO cart(itemName, quantity, price) VALUES(@itemName, @quantity, @price)";
            using var cmd = new MySqlCommand(stm, con);
            
            cmd.Parameters.AddWithValue("@itemName", value);
            cmd.Parameters.AddWithValue("@quantity", 1);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            cart addparm = new cart(){itemName =value, quantity =0, price=price};
            // addChickenParm.Add(addparm);
        }
    }
}
