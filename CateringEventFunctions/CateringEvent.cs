using System;

namespace API.CateringEventFunctions
{
    public class CateringEvent
    {
        public int OrderEventID {get; set;}
        public int OrderID{get; set;}
        public DateTime orderPlaced {get; set;}
        public DateTime orderDate {get; set;}
        public bool fulfilledStatus {get; set;}
        public int orderEventMethod {get; set;}
        public string orderDescription {get; set;}
    }
}