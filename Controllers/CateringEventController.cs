using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Cartfunctions.getCart;
using API.CateringEventFunctions;
using API.CateringEventFunctions.addEvent;
using API.CateringEventFunctions.getEvents;
using API.CateringEventFunctions.removeEvent;
using API.CateringEventFunctions.updateEvents;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ttcapi.CateringEventFunctions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateringEventController : ControllerBase
    {
        [EnableCors("AnotherPolicy")]
        // GET: api/CateringEvent
        [HttpGet]
        public List<CateringEvent> Get()
        {
            iReadAllEventData readEventObject = new readEventData();
            return readEventObject.GetAllItems();
        }

        // // GET: api/CateringEvent/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/CateringEvent
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] List<CateringEvent> totalEvents)
        {
            Console.WriteLine(totalEvents);
            // putEventTotals putEvent = new putEventTotals();
            // putEvent.putEventTotalsData(totalEvents);
        }

        // PUT: api/CateringEvent/5
        [EnableCors("AnotherPolicy")]
        [HttpPut]
        public void Put([FromBody] List<CateringEvent> totalEvents)
        {
            // Console.WriteLine(totalEvents);
            // putEventTotals putEvent = new putEventTotals();
            // putEvent.putEventTotalsData(totalEvents);
            // iAddEvent putObject = new addEvent();
            // putObject.addOrderEvent(value.OrderID, value.orderPlaced, value.orderDate, value.fulfilledStatus, value.orderEventMethod, value.orderDescription);
        }

        // DELETE: api/CateringEvent/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iDelEvent deleteObject = new delEvent();
            deleteObject.DeleteOrderEvent(id);
            Console.WriteLine(id);
        }
    }
}
