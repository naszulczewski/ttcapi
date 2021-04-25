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
        public List<cart> Get()
        {
            LeastPopularItem leastPopItem = new LeastPopularItem();
            return leastPopItem.LeastPopularItemReport();
        }

        // // GET: api/leastPopItemsReport/5
        // [EnableCors("AnotherPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/leastPopItemsReport
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/leastPopItemsReport/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/leastPopItemsReport/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
