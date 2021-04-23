using System;
using API.Cartfunctions;
using System.Data.SQLite;
using API.CateringEventFunctions.removeEvent;
using API;
using MySql.Data.MySqlClient;

namespace API.CateringEventFunctions.updateEvents
{
    public class saveEventData : iPostEvent
    {
        public void UpdateEvent(int OrderID, DateTime orderPlaced, DateTime orderDate, bool fulfilledStatus, int orderEventMethod, string orderDescription)
        {
            // string cs = @"URI=file:../OrderEvent.db"; // make this a static class!!
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // cmd.CommandText = @"INSERT INTO OrderEvent(orderID, orderPlaced, orderDate, fulfilledStatus, orderEventMethod, orderDescription) VALUES(@orderID, @orderPlaced, @fulfilledStatus, @orderEventMethod, @orderDescription)";
            string stm = @"INSERT INTO OrderEvent(OrderID, orderPlaced, orderDate, fulfilledStatus, orderEventMethod, orderDescription) VALUES(@orderID, @orderPlaced, @fulfilledStatus, @orderEventMethod, @orderDescription)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            cmd.Parameters.AddWithValue("@orderPlaced", DateTime.Now);
            cmd.Parameters.AddWithValue("orderDate", orderDate);
            cmd.Parameters.AddWithValue("@fulfilledStatus", fulfilledStatus);
            cmd.Parameters.AddWithValue("@orderEventMethod", orderEventMethod);
            cmd.Parameters.AddWithValue("@orderDescription", orderDescription);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
