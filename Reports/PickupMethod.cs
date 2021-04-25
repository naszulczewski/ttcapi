

// using System.Collections.Generic;
// using API;
// using API.CateringEventFunctions;
// using API.Reports;
// using MySql.Data.MySqlClient;

// namespace ttcapi.Reports
// {
//     public class PickupMethod
//     {
//         public List<CateringEvent> PickupMethodReport()
//         {
//             List<CateringEvent> cartTotals = new List<CateringEvent>(); //orderevent is name of table

//             ConnectionString myConnection = new ConnectionString();
//             string cs = myConnection.cs;

//             using var con = new MySqlConnection(cs);
//             con.Open();

//             // string stm = "CREATE VIEW PickupOrders AS SELECT OrderID, COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 1);";
//             // using var cmd = new MySqlCommand(stm, con);

//             // cmd.ExecuteNonQuery();

//             // string stm1 = "CREATE VIEW DeliveryOrders AS SELECT OrderID, COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 2);";
//             // using var cmd1 = new MySqlCommand(stm1, con);

//             // // cmd1.ExecuteNonQuery();

//             // // string stm2 = "SELECT TOP 1 COUNT(fulfilledStatus), OrderID FROM PickupOrders, DeliveryOrders GROUP BY OrderID, fulfilledStatus ORDER BY fulfilledStatus asc;";
//             // // using var cmd2 = new MySqlCommand(stm2, con);

//             // // cmd2.ExecuteNonQuery();

//             // string stm3 = "SELECT TOP 1 (COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 1) / (SELECT COUNT(DISTINCT OrderID) FROM orderevents) AS PercentPickup), (COUNT( SELECT fulfilledStatus FROM orderevent WHERE fulfilledStatus == 2) / (SELECT COUNT(DISTINCT OrderID) FROM orderevents) AS PercentDelivery) FROM orderevent;";
//             // using var cmd3 = new MySqlCommand(stm3, con);

//             // cmd3.ExecuteNonQuery();

//             // // using MySqlDataReader rdr = cmd.ExecuteReader();

//             // // while(rdr.Read())
//             // // {
//             // //     carttotals temp = new carttotals(){OrderID = rdr.GetInt32(1), itemName = rdr.GetString(2), price = rdr.GetFloat(3), quantity = rdr.GetInt32(4)};
//             // //     cartTotals.Add(temp);
//             // // }

//             // return cartTotals;
//         }
//     }
// }