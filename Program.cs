using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TTCatering.Cartfunctions;
using API.TotalCartFunctions;
using API.CateringEventFunctions.createEvent;
using ttcapi.orderIDCreation;
using API;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            seedData seed = new seedData();
            seed.SeedData();

            // seedTotalData seedie = new seedTotalData();
            // seedie.SeedData();

            // seedOrderTable seedOrder = new seedOrderTable();
            // seedOrder.seedOrderTableData();

            // seedEventData seedEvent = new seedEventData();
            // seedEvent.SeedAllEventData();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
