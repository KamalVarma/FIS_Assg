using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/<DriverController>
        static List<Driver> drivers = new List<Driver>()
        {
            new Driver{DriverID=1,DriverName="Lokesh",DriverPhone=764783,LicenseNo="lm7658"},
                new Driver{DriverID=2,DriverName="Abhishek",DriverPhone=807689,LicenseNo="am9854"}
        };




        // GET: api/<DriverController>
        [HttpGet]
        public IEnumerable<Driver> Get()
        {

            return drivers;
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverController>
        [HttpPost]
        public Driver Post([FromBody] Driver driver)
        {
            drivers.Add(driver);
            return driver;
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public IEnumerable<Driver> Put(int id, [FromBody] Driver driver)
        {
            drivers[id - 1] = driver;
            return drivers;
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Driver> Delete(int id)
        {
            drivers.RemoveAt(id - 1);
            return drivers;
        }
    }
}
