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
        public void putEventTotalsData(CateringEvent totalEvents)
        {
            Console.WriteLine("made it to the put event totals data");

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // maxIDfinder maxID = new maxIDfinder();
            int OrderID = maxIDfinder.find();

            Console.WriteLine(totalEvents.orderEventMethod);

            // Boolean fulfilledStatus = false;

            // DateTime orderPlaced = DateTime.Now;

            // foreach(CateringEvent item in totalEvents)
            // {

                string stm = "INSERT INTO orderevent(OrderID, orderPlaced, orderDate, fulfilledStatus, orderEventMethod, orderDescription) VALUES(@OrderID, @orderPlaced, @orderDate, @fulfilledStatus, @orderEventMethod, @orderDescription)";
                using var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@OrderID", OrderID);
                cmd.Parameters.AddWithValue("@orderPlaced", totalEvents.orderPlaced); //added totalevents
                cmd.Parameters.AddWithValue("@orderDate", totalEvents.orderDate);
                cmd.Parameters.AddWithValue("@fulfilledStatus", totalEvents.fulfilledStatus); //added totalevents
                cmd.Parameters.AddWithValue("@orderEventMethod", totalEvents.orderEventMethod);
                cmd.Parameters.AddWithValue("@orderDescription",  totalEvents.orderDescription);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            // }
        }
    }
}