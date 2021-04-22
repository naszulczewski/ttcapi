using System.Collections.Generic;
using API.Cartfunctions;
using System.Data.SQLite;
namespace API.Cartfunctions.getCart
{
    public class readData : iReadAllData
    {
        public List<cart> GetAllItems()
        {
            List<cart> allItems = new List<cart>();

            string cs = @"URI=file:../cart.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM cart";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){cartid = rdr.GetInt32(0), itemName = rdr.GetString(1), price = rdr.GetDouble(2), quantity = rdr.GetInt32(3)};
                allItems.Add(temp);
            }

            return allItems;
        }
    }
}