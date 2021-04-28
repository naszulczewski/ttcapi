using System;
using System.Data.SQLite;

namespace API.CateringEventFunctions.addEvent
{
    public interface iAddEvent
    {
         public void addOrderEvent(int orderID, string orderPlaced, string orderDate, bool fulfilledStatus, string orderEventMethod, string orderDescription);
    }
}