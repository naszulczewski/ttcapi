using System;

namespace API.CateringEventFunctions
{
    public class CateringEvent
    {
        public int OrderEventID { get; set; }
        public int OrderID { get; set; }
        public DateTime orderPlaced { get; set; }
        public DateTime orderDate { get; set; }
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