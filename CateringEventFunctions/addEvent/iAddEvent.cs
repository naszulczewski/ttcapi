using System;
using System.Data.SQLite;

namespace API.CateringEventFunctions.addEvent
{
    public interface iAddEvent
    {
         public void addOrderEvent(int orderID, DateTime orderPlaced, DateTime orderDate, bool fulfilledStatus, int orderEventMethod, string orderDescription);
    }
}