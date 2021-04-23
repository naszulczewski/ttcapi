using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace API.TotalCartFunctions
{
    public class seedTotalData
    {
        public void SeedData()
        {
            // string cs = @"URI=file:../carttotals.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open(); 

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm1 = @"DROP TABLE IF EXISTS carttotals";

            using var cmd1 = new MySqlCommand(stm1, con);
            cmd1.ExecuteNonQuery();

            string stm2 = @"CREATE TABLE carttotals(carttotalsID INTEGER PRIMARY KEY, OrderID INTEGER , itemName TEXT, price DOUBLE, quantitiy INTEGER, FOREIGN KEY (OrderID) REFERENCES OrderIDTable(OrderID))";
            // totalprice DOUBLE, qckparm INTEGER, qccc INTEGER, qvegb INTEGER, qcss INTEGER, qturk INTEGER, qhouse INTEGER, pckparm DOUBLE, pccc DOUBLE, pvegb DOUBLE, pcss DOUBLE, pturk DOUBLE, phouse DOUBLE)";
            // OrderID INTEGER 
            //FOREIGN KEY (OrderID) REFERENCES OrderIDTable(OrderID)
            using var cmd2 = new MySqlCommand(stm2, con);
            cmd2.ExecuteNonQuery();
        }
    }
}