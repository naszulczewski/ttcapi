

using System.Collections.Generic;
using API;
using MySql.Data.MySqlClient;

namespace ttcapi.Reports
{
    public class PickupMethod
    {
        public List<orderevent> PickupMethodReport()
        {
            List<orderevent> cartTotals = new List<orderevents>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // string stm = "CREATE VIEW PickupOrders AS SELECT OrderID, COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 1);";
            // using var cmd = new MySqlCommand(stm, con);

            // cmd.ExecuteNonQuery();

            // string stm1 = "CREATE VIEW DeliveryOrders AS SELECT OrderID, COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 2);";
            // using var cmd1 = new MySqlCommand(stm1, con);

            // cmd1.ExecuteNonQuery();

            // string stm2 = "SELECT TOP 1 COUNT(fulfilledStatus), OrderID FROM PickupOrders, DeliveryOrders GROUP BY OrderID, fulfilledStatus ORDER BY fulfilledStatus asc;";
            // using var cmd2 = new MySqlCommand(stm2, con);

            // cmd2.ExecuteNonQuery();

            string stm3 = "SELECT TOP 1 (COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 1) / (SELECT COUNT(DISTINCT OrderID) FROM orderevents) AS PercentPickup), (COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 2) / (SELECT COUNT(DISTINCT OrderID) FROM orderevents) AS PercentDelivery) FROM orderevent;";
            using var cmd3 = new MySqlCommand(stm3, con);

            cmd3.ExecuteNonQuery();

            return cartTotals;
        }
    }
}