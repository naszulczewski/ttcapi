using System;
using System.Data.SQLite;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace API.CateringEventFunctions.addEvent
{
    public class addEvent : iAddEvent
    {
        public void addOrderEvent(int OrderID, string orderPlaced, string orderDate, bool fulfilledStatus, string orderEventMethod, string orderDescription)
        {
            // string cs = @"URI=file:../OrderEvents.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE cart set quantity = '" + "' WHERE OrderID = @id";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", OrderID);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}