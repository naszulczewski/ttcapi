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

            while(rdr.Read())
            {
                CateringEvent temp = new CateringEvent(){OrderID = rdr.GetInt32(0), orderPlaced = rdr.GetDateTime(10), orderDate = rdr.GetDateTime(10), fulfilledStatus = rdr.GetBoolean(5), orderEventMethod = rdr.GetInt32(2), orderDescription = rdr.GetString(32)};
                allCateringEvents.Add(temp);
            }

            return allCateringEvents;
        }
    }
}