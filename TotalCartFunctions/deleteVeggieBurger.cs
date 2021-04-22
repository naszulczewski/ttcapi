using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;

namespace API.TotalCartFunctions
{
    public class deleteVeggieBurger
    {
        public static void Delete(int id)
        {
            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            string stm = @"DELETE FROM carttotals WHERE orderID =@id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}