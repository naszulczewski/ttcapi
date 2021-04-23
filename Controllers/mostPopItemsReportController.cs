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

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mostPopItemsReportController : ControllerBase
    {
        // GET: api/mostPopItemsReport
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<carttotals> Get()
        {
            MostPopularItem popItem = new MostPopularItem();
            return popItem.MostPopularItemReport();
        }

        // GET: api/mostPopItemsReport/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/mostPopItemsReport
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/mostPopItemsReport/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/mostPopItemsReport/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
