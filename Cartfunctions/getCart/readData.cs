using System.Collections.Generic;
using API.Cartfunctions;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace API.Cartfunctions.getCart
{
    public class readData : iReadAllData
    {
        public List<cart> GetAllItems()
        {
            List<cart> allItems = new List<cart>();

            // string cs = @"URI=file:../cart.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM cart";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){cartid = rdr.GetInt32(0), itemName = rdr.GetString(1), price = rdr.GetDouble(2), quantity = rdr.GetInt32(3)};
                allItems.Add(temp);
            }

            return allItems;
        }
    }
}