using System.Collections.Generic;
using API;
using API.CateringEventFunctions;
using MySql.Data.MySqlClient;

namespace ttcapi.Reports
{
    public class OrdersByMonth
    {
        public List<CateringEvent> OrdersByMonthReport()
        {
            List<CateringEvent> monthly = new List<CateringEvent>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "DROP VIEW jan;";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();

            string stm6 = "DROP VIEW feb;";
            using var cmd6 = new MySqlCommand(stm6,con);

            cmd6.ExecuteNonQuery();

            string stm1 = "DROP VIEW march;";
            using var cmd1 = new MySqlCommand(stm1, con);

            cmd1.ExecuteNonQuery();

            string stm7 = "DROP VIEW apr;";
            using var cmd7 = new MySqlCommand(stm7,con);

            cmd7.ExecuteNonQuery();

            string stm2 = "DROP VIEW may;";
            using var cmd2 = new MySqlCommand(stm2, con);

            cmd2.ExecuteNonQuery();

            string stm3 = "DROP VIEW june;";
            using var cmd3 = new MySqlCommand(stm3, con);

            cmd3.ExecuteNonQuery();

            string stm4 = "DROP VIEW july;";
            using var cmd4 = new MySqlCommand(stm4, con);

            cmd4.ExecuteNonQuery();

            string stm8 = "DROP VIEW aug;";
            using var cmd8 = new MySqlCommand(stm8, con);

            cmd8.ExecuteNonQuery();

            string stm9 = "DROP VIEW sep;";
            using var cmd9 = new MySqlCommand(stm9, con);

            cmd9.ExecuteNonQuery();

            string stm10 = "DROP VIEW octo;";
            using var cmd10 = new MySqlCommand(stm10, con);

            cmd10.ExecuteNonQuery();

            string stm11 = "DROP VIEW nov;";
            using var cmd11 = new MySqlCommand(stm11, con);

            cmd11.ExecuteNonQuery();

            string stm12 = "DROP VIEW decem;";
            using var cmd12 = new MySqlCommand(stm12, con);

            cmd12.ExecuteNonQuery();

            string stm13 = "CREATE VIEW jan AS SELECT COUNT(OrderID) as January FROM orderevent WHERE MONTH(orderdate) = 01;";
            using var cmd13 = new MySqlCommand(stm13, con);
            cmd13.ExecuteNonQuery();

            string stm14 = "CREATE VIEW feb AS SELECT COUNT(OrderID) as February FROM orderevent WHERE MONTH(orderdate) = 02;"; 
            using var cmd14 = new MySqlCommand(stm14, con);
            cmd14.ExecuteNonQuery();

            string stm15 = "CREATE VIEW march AS SELECT COUNT(OrderID) as March FROM orderevent WHERE MONTH(orderdate) = 03;";
            using var cmd15 = new MySqlCommand(stm15, con);
            cmd15.ExecuteNonQuery();

            string stm16 = "CREATE VIEW apr AS SELECT COUNT(OrderID) as April FROM orderevent WHERE MONTH(orderdate) = 04;";
            using var cmd16 = new MySqlCommand(stm16, con);
            cmd16.ExecuteNonQuery();

            string stm17 = "CREATE VIEW may AS SELECT COUNT(OrderID) as May FROM orderevent WHERE MONTH(orderdate) = 05;";
            using var cmd17 = new MySqlCommand(stm17, con);
            cmd17.ExecuteNonQuery();

            string stm18 = "CREATE VIEW june AS SELECT COUNT(OrderID) as June FROM orderevent WHERE MONTH(orderdate) = 06;";
            using var cmd18 = new MySqlCommand(stm18, con);
            cmd18.ExecuteNonQuery();

            string stm19 = "CREATE VIEW july AS SELECT COUNT(OrderID) as July FROM orderevent WHERE MONTH(orderdate) = 07;";
            using var cmd19 = new MySqlCommand(stm19, con);
            cmd19.ExecuteNonQuery();

            string stm20 = "CREATE VIEW aug AS SELECT COUNT(OrderID) as August FROM orderevent HERE MONTH(orderdate) = 08;";
            using var cmd20 = new MySqlCommand(stm20, con);
            cmd20.ExecuteNonQuery();

            string stm21 = "CREATE VIEW sep AS SELECT COUNT(OrderID) as September FROM orderevent WHERE MONTH(orderdate) = 09;";
            using var cmd21 = new MySqlCommand(stm21, con);
            cmd21.ExecuteNonQuery();

            string stm22 = "CREATE VIEW octo AS SELECT COUNT(OrderID) as October FROM orderevent WHERE MONTH(orderdate) = 10;";
            using var cmd22 = new MySqlCommand(stm22, con);
            cmd22.ExecuteNonQuery();

            string stm23 = "CREATE VIEW nov AS SELECT COUNT(OrderID) as November FROM orderevent WHERE MONTH(orderdate) = 11;";
            using var cmd23 = new MySqlCommand(stm23, con);
            cmd23.ExecuteNonQuery();

            string stm24 = "CREATE VIEW decem AS SELECT COUNT(OrderID) as December FROM orderevent WHERE MONTH(orderdate) = 12;";
            using var cmd24 = new MySqlCommand(stm24, con);
            cmd24.ExecuteNonQuery();

            string stm25 = "(SELECT * FROM jan);";
            using var cmd25 = new MySqlCommand(stm25, con);
            cmd25.ExecuteNonQuery();

            string stm26 = "(SELECT * FROM feb);";
            using var cmd26 = new MySqlCommand(stm26, con);
            cmd26.ExecuteNonQuery();

            string stm27 = "(SELECT * FROM march);";
            using var cmd27 = new MySqlCommand(stm27, con);
            cmd27.ExecuteNonQuery();

            string stm28 = "(SELECT * FROM apr);";
            using var cmd28 = new MySqlCommand(stm28, con);
            cmd28.ExecuteNonQuery();

            string stm29 = "(SELECT * FROM may);";
            using var cmd29 = new MySqlCommand(stm29, con);
            cmd29.ExecuteNonQuery();

            string stm30 = "(SELECT * FROM june);";
            using var cmd30 = new MySqlCommand(stm30, con);
            cmd30.ExecuteNonQuery();

            string stm31 = "(SELECT * FROM july);";
            using var cmd31 = new MySqlCommand(stm31, con);
            cmd31.ExecuteNonQuery();

            string stm32 = "(SELECT * FROM aug);";
            using var cmd32 = new MySqlCommand(stm32, con);
            cmd32.ExecuteNonQuery();

            string stm33 = "(SELECT * FROM sep);";
            using var cmd33 = new MySqlCommand(stm33, con);
            cmd33.ExecuteNonQuery();

            string stm34 = "(SELECT * FROM octo);";
            using var cmd34 = new MySqlCommand(stm34, con);
            cmd34.ExecuteNonQuery();

            string stm35 = "(SELECT * FROM nov);";
            using var cmd35 = new MySqlCommand(stm35, con);
            cmd35.ExecuteNonQuery();

            string stm36 = "(SELECT * FROM decem);";
            using var cmd36 = new MySqlCommand(stm36, con);
            cmd36.ExecuteNonQuery();
            
            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                CateringEvent temp = new CateringEvent(){OrderID = rdr.GetInt32(0)};
                monthly.Add(temp);
            }

            return monthly;
        }
    }
}