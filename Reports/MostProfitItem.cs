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

            // int viewNum = 3;

            // string stm = @$"CREATE VIEW ChickenParmTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd = new MySqlCommand(stm, con);

            // cmd.ExecuteNonQuery();

            // string stm1 = @$"CREATE VIEW ChocolateChipCookiesTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd1 = new MySqlCommand(stm1, con);

            // cmd1.ExecuteNonQuery();

            // string stm2 = @$"CREATE VIEW VeggieBurgersTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd2 = new MySqlCommand(stm2, con);

            // cmd2.ExecuteNonQuery();

            // string stm3 = @$"CREATE VIEW ChickenSaladSandwichesTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd3 = new MySqlCommand(stm3, con);

            // cmd3.ExecuteNonQuery();

            // string stm4 = @$"CREATE VIEW TurkeyMeltTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd4 = new MySqlCommand(stm4, con);

            // cmd4.ExecuteNonQuery();

            // string stm5 = @$"CREATE VIEW HouseSaladTotalProfit{viewNum} AS SELECT itemName, SUM(quantity * price) AS TotalAmount FROM carttotals GROUP BY itemName;";
            // using var cmd5 = new MySqlCommand(stm5, con);

            // cmd5.ExecuteNonQuery();

            string stm6 = "SELECT DISTINCT itemName, SUM(OrderID)*price AS totalquantity FROM carttotals GROUP BY itemName ORDER BY SUM(OrderID) DESC LIMIT 1;";
            using var cmd6 = new MySqlCommand(stm6, con);

            cmd6.ExecuteNonQuery();

            using MySqlDataReader rdr = cmd6.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){itemName = rdr.GetString(0), price = rdr.GetInt32(1)};
                mostProfitableItem.Add(temp);
            }

            return mostProfitableItem;
        }
    }
}