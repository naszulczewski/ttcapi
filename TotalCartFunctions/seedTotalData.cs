using System;
using System.Data.SQLite;
using API.TotalCartFunctions;

namespace API.TotalCartFunctions
{
    public class seedTotalData
    {
        public void SeedData()
        {
            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open(); 

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE TABLE carttotals(orderID INTEGER PRIMARY KEY, totalprice DOUBLE, qckparm INTEGER, qccc INTEGER, qvegb INTEGER, qcss INTEGER, qturk INTEGER, qhouse INTEGER, pckparm DOUBLE, pccc DOUBLE, pvegb DOUBLE, pcss DOUBLE, pturk DOUBLE, phouse DOUBLE)";
            cmd.ExecuteNonQuery();
        }
    }
}