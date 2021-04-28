using System;

namespace API.CateringEventFunctions
{
    public class CateringEvent
    {
        public int OrderEventID { get; set; }
        public int OrderID { get; set; }
        public DateTime orderPlaced { get; set; } // turn this into a string
        public DateTime orderDate { get; set; } // Turn this into a string
        public bool fulfilledStatus { get; set; }
        public string orderEventMethod { get; set; }
        public string orderDescription { get; set; }

        public override string ToString()
        {
            string value = OrderEventID + " " + OrderID + " " + orderEventMethod + " " + orderDescription;
            return value;
        }
    }
}