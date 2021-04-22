using API;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;

namespace ttcapi.orderIDCreation
{
    public class createOrderID
    {
        public void seedDataID()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            // string stm = @"INSERT INTO OrderIDTable()";
            string stm = @"INSERT INTO OrderIDTable(filler) VALUES(@filler)";
            using var cmd = new MySqlCommand(stm, con);
            Console.WriteLine("made it to INSERT");
            string fillerv = "filler";
            cmd.Parameters.AddWithValue("@filler", fillerv);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}