using System;

namespace API.CateringEventFunctions
{
    public class CateringEvent
    {
        public int orderID{get; set;}
        public DateTime orderPlaced {get; set;}
        public DateTime orderDate {get; set;}
        public bool fulfilledStatus {get; set;}
        public int orderEventMethod {get; set;}
        public string orderDescription {get; set;}
    }
}