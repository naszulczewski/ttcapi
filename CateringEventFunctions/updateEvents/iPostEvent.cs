using System;
using API.Cartfunctions;

namespace API.CateringEventFunctions.removeEvent
{
    public interface iPostEvent
    {
        public void UpdateEvent(int orderID, string orderPlaced, string orderDate, bool fulfilledStatus, string orderEventMethod, string orderDescription);
    }
}
