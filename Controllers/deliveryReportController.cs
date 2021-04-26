using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Reports;
using Microsoft.AspNetCore.Cors;
using API.TotalCartFunctions;
using API.Cartfunctions;
using ttcapi.orderIDCreation;
using ttcapi.Reports;
using API;
using API.CateringEventFunctions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deliveryReportController : ControllerBase
    {
        // GET: api/deliveryReport
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<string> Get()
        {
            DeliveryMethod deliveries = new DeliveryMethod();
            return deliveries.DeliveryMethodReport();
        }

        // // GET: api/deliveryReport/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/deliveryReport
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/deliveryReport/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/deliveryReport/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
