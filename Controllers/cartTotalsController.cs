using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ttcapi.TotalCartFunctions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cartTotalsController : ControllerBase
    {
        // GET: api/cartTotals
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // // GET: api/cartTotals/5
        // [EnableCors("AnotherPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/cartTotals
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] int OrderID)
        {
            postCartTotal postCart = new postCartTotal();
            postCart.postCartTotalData(OrderID);
        }

        // PUT: api/cartTotals/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/cartTotals/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
