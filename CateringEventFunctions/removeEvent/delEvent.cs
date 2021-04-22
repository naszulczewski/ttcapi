using System;
using API.CateringEventFunctions;
using System.Data.SQLite;
using API;
using MySql.Data.MySqlClient;

namespace API.CateringEventFunctions.removeEvent
{
    public class delEvent : iDelEvent
    {
        public void DeleteOrderEvent(int value)
        {
            // string cs = @"URI=file:../OrderEvent.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM OrderEvent WHERE OrderID =@id";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
