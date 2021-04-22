using System;
using System.Data.SQLite;
using API.TotalCartFunctions;
using API.Cartfunctions;

namespace API.TotalCartFunctions
{
    public class addChocChipCookie
    {
        public static void Add(cart value)
        {
            Console.WriteLine("made it to add");
            int id = maxIDfinder.find();
            Console.WriteLine(id);
            string cs = @"URI=file:../carttotals.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            
            var newQ = value.quantity +1;
            var newP = 0.0;
            if(value.quantity == 0){
                newP = value.price * newQ;
            }
            else
            {
                newP = (value.price / value.quantity) * newQ;
            }
            Console.WriteLine(value.price + " "+ newQ);

            string stm = @$"UPDATE carttotals set qccc = {newQ}, pccc = {newP} WHERE orderID = @id";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}