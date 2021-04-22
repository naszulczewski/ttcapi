using System;
using API.Cartfunctions;
// using System.Data.SQLite;
using API.TotalCartFunctions;
using MySql.Data.MySqlClient;
using MySql.Data;
using API;

namespace TTCatering.Cartfunctions.addCart
{
    public class addCart : iAddCart
    {
        public void addCartItem(int id, cart value)
        {
            // string cs = @"URI=file:../cart.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();
            
            var newQ = value.quantity +1;
            var newP = (value.price / value.quantity) * newQ;
            Console.WriteLine(value.price + " "+ newQ);

            string stm = @$"UPDATE cart set quantity = {newQ}, price = {newP} WHERE cartid = @id";
            using var cmd = new MySqlCommand(stm, con);
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            // addChickenParm.Add(value);
        }
    }
}
