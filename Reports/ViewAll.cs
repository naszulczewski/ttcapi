using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;
using System.Collections.Generic;

namespace API.Reports
{
    public class ViewAll
    {
        public List<carttotals> ViewAllReports()
        {
            Console.WriteLine("made it to viewallreports");
            List<carttotals> cartTotals = new List<carttotals>();

            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM carttotals";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                carttotals temp = new carttotals(){orderID = rdr.GetInt32(0), totalprice = rdr.GetDouble(1), qckparm = rdr.GetInt32(2), qccc = rdr.GetInt32(3), qvegb = rdr.GetInt32(4), qcss = rdr.GetInt32(5), qturk = rdr.GetInt32(6), qhouse = rdr.GetInt32(7), pckparm = rdr.GetDouble(7), pccc = rdr.GetDouble(8), pvegb = rdr.GetDouble(9), pcss = rdr.GetDouble(10), pturk = rdr.GetDouble(11), phouse = rdr.GetDouble(12)};
                cartTotals.Add(temp);
            }

            return cartTotals;
        }
    }
}