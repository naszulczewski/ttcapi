using System.Collections.Generic;
using API.CateringEventFunctions;
using System;
using System.Data.SQLite;
using System.IO;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace API.CateringEventFunctions.getEvents
{
    public class readEventData : iReadAllEventData
    {
        public List<CateringEvent> GetAllItems()
        {
            List<CateringEvent> allCateringEvents = new List<CateringEvent>();

            // string cs = @"URI=file:../OrderEvent.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM OrderEvent";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //CateringEvent temp = new CateringEvent() { OrderID = rdr.GetInt32(0), orderPlaced = rdr.GetString(1), orderDate = rdr.GetString(2), fulfilledStatus = rdr.GetInt32(3), orderEventMethod = rdr.GetString(4), orderDescription = rdr.GetString(5) };
                CateringEvent temp = new CateringEvent() { OrderID = rdr.GetInt32(1), orderPlaced = rdr.GetString(2), orderDate = rdr.GetString(3), fulfilledStatus = 0, orderEventMethod = rdr.GetString(5), orderDescription = rdr.GetString(6) };
                allCateringEvents.Add(temp);
            }

            return allCateringEvents;
        }
    }
}