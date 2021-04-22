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

            string stm2 = @"CREATE TABLE OrderIDTable(OrderID INTEGER PRIMARY KEY AUTO_INCREMENT, filler TEXT)";

            // string stm3 = @"INSERT INTO OrderIDTable (OrderID) VALUES 1";
            // instead put parameters where the one is unless we need to hardcode a one for seeding
            // Insert data so it doesn't come back null

            using var cmd2 = new MySqlCommand(stm2, con);

            cmd2.ExecuteNonQuery();
        }
    }
}