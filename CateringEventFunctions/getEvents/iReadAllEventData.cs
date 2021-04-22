using System;
using System.Collections.Generic;
using API.CateringEventFunctions;

namespace API.CateringEventFunctions.getEvents
{
    public interface iReadAllEventData
    {
        public List<CateringEvent> GetAllItems();
    }
}
