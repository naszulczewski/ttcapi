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
    public class leastPopItemsReportController : ControllerBase
    {
        // GET: api/leastPopItemsReport
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<carttotals> Get()
        {
            MostPopularItem popItem = new MostPopularItem();
            return popItem.MostPopularItemReport();
        }

        // GET: api/leastPopItemsReport/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/leastPopItemsReport
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/leastPopItemsReport/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/leastPopItemsReport/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}