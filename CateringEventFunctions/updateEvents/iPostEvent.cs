using System;
using API.Cartfunctions;

namespace API.CateringEventFunctions.removeEvent
{
    public interface iPostEvent
    {
        public void UpdateEvent(int orderID, DateTime orderPlaced, DateTime orderDate, bool fulfilledStatus, int orderEventMethod, string orderDescription);
    }
}
