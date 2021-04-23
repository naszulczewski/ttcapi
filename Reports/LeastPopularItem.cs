using System.Collections.Generic;
using API;
using API.Reports;
using MySql.Data.MySqlClient;

namespace ttcapi.Reports
{
    public class LeastPopularItem
    {
        public List<carttotals> LeastPopularItemReport()
        {
            List<carttotals> cartTotals = new List<carttotals>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT TOP 1 itemName, quantity FROM carttotals GROUP BY itemName, quantity ORDER BY quantity asc;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            return cartTotals;
        }
    }
}