using MySql.Data.MySqlClient;
using MySql.Data;
using ttcapi;
using API;

namespace ttcapi.orderIDCreation
{
    public class seedOrderTable
    {
        public void seedOrderTableData()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm1 = "DROP TABLE IF EXISTS OrderIDTable";
            using var cmd = new MySqlCommand(stm1, con);
            
            cmd.ExecuteNonQuery();

            string stm2 = @"CREATE TABLE OrderIDTable(OrderID INTEGER PRIMARY KEY AUTO_INCREMENT)";

            using var cmd1 = new MySqlCommand(stm2, con);

            cmd1.ExecuteNonQuery();
        }
    }
}