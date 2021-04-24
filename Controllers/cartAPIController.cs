using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTCatering.Cartfunctions.addCart;
using TTCatering.Cartfunctions;
using API.Cartfunctions.getCart;
using TTCatering.Cartfunctions.removeCart;
using TTCatering.Cartfunctions.updateCart;
using API.Cartfunctions;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cartAPIController : ControllerBase
    {
        // GET: api/cartAPI
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<cart> Get()
        {
            iReadAllData readObject = new readData();
            return readObject.GetAllItems();
        }

        // // GET: api/cartAPI/5
        // //[EnableCors("AnotherPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/cartAPI
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] cart value)
        {
            Console.WriteLine(value);
            iPostCart insertObject = new saveData();
            insertObject.UpdateCart(value.itemName, value.price);
        }

        // PUT: api/cartAPI/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] cart value)
        {
            Console.WriteLine(value.OrderID);
            iAddCart putObject = new addCart();
            putObject.addCartItem(id, value);
            
        }

        // DELETE: api/cartAPI/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iDelCart deleteObject = new delCart();
            deleteObject.DeleteCartItem(id);
            Console.WriteLine(id);
        }
    }
}
