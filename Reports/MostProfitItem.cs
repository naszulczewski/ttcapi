using System.Collections.Generic;
using API;
using MySql.Data.MySqlClient;
using MySql.Data;
using API.Reports;
using API.Cartfunctions;

namespace ttcapi.Reports
{
    public class MostProfitItem
    {
        public List<cart> MostProfitItemReport()
        {
            List<cart> mostProfitableItem = new List<cart>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // string stm = "CREATE VIEW ChickenParmTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd = new MySqlCommand(stm, con);

            // cmd.ExecuteNonQuery();

            // string stm1 = "CREATE VIEW ChocolateChipCookiesTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd1 = new MySqlCommand(stm1, con);

            // cmd1.ExecuteNonQuery();

            // string stm2 = "CREATE VIEW VeggieBurgersTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd2 = new MySqlCommand(stm2, con);

            // cmd2.ExecuteNonQuery();

            // string stm3 = "CREATE VIEW ChickenSaladSandwichesTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd3 = new MySqlCommand(stm3, con);

            // cmd3.ExecuteNonQuery();

            // string stm4 = "CREATE VIEW TurkeyMeltTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd4 = new MySqlCommand(stm4, con);

            // cmd4.ExecuteNonQuery();

            // string stm5 = "CREATE VIEW HouseSaladTotalProfit2 AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd5 = new MySqlCommand(stm5, con);

            // cmd5.ExecuteNonQuery();


            string stm6 = "(SELECT itemName, TotalAmount FROM ChickenParmTotalProfit2 ORDER BY TotalAmount desc LIMIT 1) UNION (SELECT itemName, TotalAmount FROM ChocolateChipCookiesTotalProfit2 ORDER BY TotalAmount desc LIMIT 1) UNION (SELECT itemName, TotalAmount FROM VeggieBurgersTotalProfit2 ORDER BY TotalAmount desc LIMIT 1) UNION (SELECT itemName, TotalAmount FROM ChickenSaladSandwichesTotalProfit2 ORDER BY TotalAmount desc LIMIT 1) UNION (SELECT itemName, TotalAmount FROM TurkeyMeltTotalProfit2 ORDER BY TotalAmount desc LIMIT 1) UNION (SELECT itemName, TotalAmount FROM HouseSaladTotalProfit2 ORDER BY TotalAmount desc LIMIT 1);";
            using var cmd6 = new MySqlCommand(stm6, con);

            cmd6.ExecuteNonQuery();

            using MySqlDataReader rdr = cmd6.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){itemName = rdr.GetString(1)};
                mostProfitableItem.Add(temp);
            }

            return mostProfitableItem;
        }
    }
}