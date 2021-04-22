using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TTCatering.Cartfunctions.removeCart
{
    public class delCart : iDelCart
    {
        public void DeleteCartItem(int value)
        {
            // string cs = @"URI=file:../cart.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM cart WHERE cartid =@id";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            // deleteChickenParm.Delete(value);
        }
    }
}
