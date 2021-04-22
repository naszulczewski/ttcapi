using API;
using MySql.Data.MySqlClient;
using MySql.Data;

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
            string stm = @"INSERT INTO OrderIDTable (OrderID) VALUES 1";
            using var cmd = new MySqlCommand(stm, con);
            
            cmd.ExecuteNonQuery();
        }
    }
}