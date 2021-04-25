using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using API;
using ttcapi;
using System.Collections.Generic;
using API.Reports;
using API.Cartfunctions;

namespace ttcapi.Reports
{
    public class MostPopularItem
    {
        public List<cart> MostPopularItemReport()
        {
            Console.WriteLine("Made it to most pop item");

            List<cart> mostPopularItem = new List<cart>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT DISTINCT itemName, SUM(OrderID) AS totalquantity FROM carttotals GROUP BY itemName ORDER BY SUM(OrderID) DESC LIMIT 1;";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                cart temp = new cart(){itemName = rdr.GetString(0), quantity = rdr.GetInt32(1)};
                mostPopularItem.Add(temp);
            }

            return mostPopularItem;
        }
    }
}