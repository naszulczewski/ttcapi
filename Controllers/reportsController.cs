using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Reports;
using Microsoft.AspNetCore.Cors;
using API.TotalCartFunctions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reportsController : ControllerBase
    {
        // GET: api/reports
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<carttotals> Get()
        {
            ViewAll test = new ViewAll();
            return test.ViewAllReports();
        }

        // // GET: api/reports/5
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/reports
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post()
        {
            pushData insertObject = new pushData();
            insertObject.pushCartData();
        }

        // PUT: api/reports/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/reports/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
