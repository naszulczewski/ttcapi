using System;
using System.Collections.Generic;
using API;
using API.CateringEventFunctions;
using API.TotalCartFunctions;
using MySql.Data.MySqlClient;

namespace ttcapi.CateringEventFunctions
{
    public class putEventTotals
    {
        public void putEventTotalsData(List<CateringEvent> totalEvents)
        {
            Console.WriteLine("made it to the put event totals data");

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // maxIDfinder maxID = new maxIDfinder();
            int OrderID = maxIDfinder.find();

            foreach(CateringEvent item in totalEvents)
            {

                string stm = "INSERT INTO orderevent(OrderID, orderPlaced, orderDate, fulfilledStatus, orderEventMethod, orderDescription) VALUES(@OrderID, @orderPlaced, @orderDate, @fulfilledStatus, @orderEventMethod, @orderDescription)";
                using var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                cmd.Parameters.AddWithValue("@orderPlaced", item.orderPlaced);
                cmd.Parameters.AddWithValue("@orderDate", item.orderDate);
                cmd.Parameters.AddWithValue("@fulfilledStatus", item.fulfilledStatus);
                cmd.Parameters.AddWithValue("@orderEventMethod", item.orderEventMethod);
                cmd.Parameters.AddWithValue("@orderDescription", item.orderDescription);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }
}