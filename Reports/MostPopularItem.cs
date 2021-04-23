using MySql.Data.MySqlClient;
using MySql.Data;
using API;
using System.Collections.Generic;
using API.Reports;

namespace ttcapi.Reports
{
    public class MostPopularItem
    {
        public List<carttotals> MostPopularItemReport()
        {
            List<carttotals> cartTotals = new List<carttotals>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT TOP 1 itemName, quantity FROM carttotals GROUP BY itemName, quantity ORDER BY quantity desc;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            return cartTotals;
        }
    }
}