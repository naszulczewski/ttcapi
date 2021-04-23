using System.Collections.Generic;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;
using API.Reports;

namespace ttcapi.Reports
{
    public class MostProfitItem
    {
        public List<carttotals> MostProfitItemReport()
        {
            List<carttotals> cartTotals = new List<carttotals>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "CREATE VIEW ChickenParmTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            string stm1 = "CREATE VIEW ChocolateChipCookiesTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd1 = new MySqlCommand(stm1, con);

            cmd1.ExecuteNonQuery();

            string stm2 = "CREATE VIEW VeggieBurgersTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd2 = new MySqlCommand(stm2, con);

            cmd2.ExecuteNonQuery();

            string stm3 = "CREATE VIEW ChickenSaladSandwichesTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd3 = new MySqlCommand(stm3, con);

            cmd3.ExecuteNonQuery();

            string stm4 = "CREATE VIEW TurkeyMeltTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd4 = new MySqlCommand(stm4, con);

            cmd4.ExecuteNonQuery();

            string stm5 = "CREATE VIEW HouseSaladTotalProfit AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            using var cmd5 = new MySqlCommand(stm5, con);

            cmd5.ExecuteNonQuery();


            string stm6 = "SELECT TOP 1 itemName, TotalAmount FROM ChickenParmTotalProfit, ChocolateChipCookiesTotalProfit, VeggieBurgersTotalProfit, ChickenSaladSandwichesTotalProfit, TurkeyMeltTotalProfit, HouseSaladTotalProfit ORDER BY TotalAmount desc;";
            using var cmd6 = new MySqlCommand(stm6, con);

            cmd6.ExecuteNonQuery();

            return cartTotals;
        }
    }
}