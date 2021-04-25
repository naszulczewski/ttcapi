

using System.Collections.Generic;
using API;
using API.CateringEventFunctions;
using API.Reports;
using MySql.Data.MySqlClient;

namespace ttcapi.Reports
{
    public class PickupMethod
    {
        public List<CateringEvent> PickupMethodReport()
        {
            List<CateringEvent> pickupEvents = new List<CateringEvent>(); //orderevent is name of table

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            // int viewNum = new Random(10,100);

            // viewNum++;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm5 = "DROP VIEW pickedup;";
            using var cmd5 = new MySqlCommand(stm5,con);

            cmd5.ExecuteNonQuery();

            string stm = "CREATE VIEW pickedup as SELECT count(*) as pickeduporders FROM orderevent WHERE (ordereventmethod = 1);";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            string stm7 = "DROP VIEW totalorders;";
            using var cmd7 = new MySqlCommand(stm7,con);

            cmd7.ExecuteNonQuery();

            string stm2 = "CREATE VIEW totalorders AS SELECT COUNT(OrderID) as totalorders FROM orderevent;";
            using var cmd2 = new MySqlCommand(stm2, con);

            cmd2.ExecuteNonQuery();

            string stm3 = "SELECT pickeduporders/totalorders AS percentpickedup FROM pickedup, totalorders;";
            using var cmd3 = new MySqlCommand(stm3, con);

            cmd3.ExecuteNonQuery();


            using MySqlDataReader rdr = cmd3.ExecuteReader();


            while(rdr.Read())
            {
                CateringEvent temp = new CateringEvent(){orderEventMethod = rdr.GetInt32(0)};
                pickupEvents.Add(temp);
            }

            // while(rdr1.Read())
            // {
            //     CateringEvent temp = new CateringEvent(){OrderID = rdr1.GetInt32(1), orderPlaced = rdr1.GetDateTime(2), orderDate = rdr1.GetDateTime(3), fulfilledStatus = rdr1.GetBoolean(4), orderEventMethod = rdr1.GetInt32(5), orderDescription = rdr1.GetString(6)};
            //     cartTotals.Add(temp);
            // }

            return pickupEvents;
        }
    }
}