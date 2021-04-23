using System;
// using System.Data.SQLite;
using API;
using API.Cartfunctions;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TTCatering.Cartfunctions
{
    public class seedData : iSeedCart
    {
        public void SeedData()
        {
            // string cs = @"URI=file:../cart.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            

            // cmd.CommandText = "DROP TABLE IF EXISTS cart";

            string stm1 = "DROP TABLE IF EXISTS cart";
            using var cmd = new MySqlCommand(stm1, con);
            
            cmd.ExecuteNonQuery();

            // cmd.CommandText = @"CREATE TABLE cart(cartid INTEGER PRIMARY KEY, itemName TEXT, price DOUBLE, quantity INTEGER)";

            string stm2 = @"CREATE TABLE cart(cartid INTEGER PRIMARY KEY AUTO_INCREMENT, itemName TEXT, price DOUBLE, quantity INTEGER)";

            using var cmd1 = new MySqlCommand(stm2, con);

            cmd1.ExecuteNonQuery();


        }
    }
}
