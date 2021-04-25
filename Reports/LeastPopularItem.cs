using System.Collections.Generic;
using API;
using API.Cartfunctions;
using API.Reports;
using MySql.Data.MySqlClient;

namespace ttcapi.Reports
{
    public class LeastPopularItem
    {
        public List<cart> LeastPopularItemReport()
        {
            List<cart> leastPopItem = new List<cart>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT DISTINCT itemName, SUM(OrderID) AS totalquantity FROM carttotals GROUP BY itemName ORDER BY SUM(OrderID) ASC LIMIT 1;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){itemName = rdr.GetString(0), quantity = rdr.GetInt32(1)};
                leastPopItem.Add(temp);
            }

            return leastPopItem;
        }
    }
}