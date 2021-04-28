using System;

namespace API.Cartfunctions
{
    public class cart
    {
        public int OrderID{get; set;}
        public string itemName{get; set;}
        public double price{get; set;}
        public int quantity {get; set;}

        // public override string ToString()
        // {
        //     string value = itemName + " " + price + " " + quantity;
        //     return value;
        // }
    }
}
