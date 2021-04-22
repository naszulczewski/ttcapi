using System;
using System.Data.SQLite;
using API.Cartfunctions;
using API;
using MySql.Data.MySqlClient;

namespace API.CateringEventFunctions.createEvent
{
    public class seedEventData : iSeedEvent
    {
        public void SeedEventData()
        {
            // string cs = @"URI=file:../OrderEvent.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();


            // cmd.CommandText = "DROP TABLE IF EXISTS OrderEvent";
            string stm1 = "DROP TABLE IF EXISTS OrderEvent";
            using var cmd = new MySqlCommand(stm1, con);
            cmd.ExecuteNonQuery();

            // cmd.CommandText = @"CREATE TABLE OrderEvent(orderID INTEGER PRIMARY KEY, orderPlaced DATETIME, orderDate DATETIME, fulfilledStatus BOOL, orderEventMethod INTEGER, orderDescription TEXT)";
            string stm2 = @"CREATE TABLE OrderEvent(orderID INTEGER PRIMARY KEY, orderPlaced DATETIME, orderDate DATETIME, fulfilledStatus BOOL, orderEventMethod INTEGER, orderDescription TEXT)";
            using var cmd1 = new MySqlCommand(stm2, con);
            cmd1.ExecuteNonQuery();
        }
    }
}
