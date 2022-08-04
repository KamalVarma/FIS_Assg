using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Passenger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        static List<Passenger> Passengers = new List<Passenger>()
            {
                new Passenger{PassengerID=1,PassengerName="Kamal",PassengerPhone=9876453},
                new Passenger{PassengerID=2,PassengerName="Omkar",PassengerPhone=7972093}
            };
        // GET: api/<PassengerController>
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {

            return Passengers;
        }

        // GET api/<PassengerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PassengerController>
        [HttpPost]
        public Passenger Post([FromBody] Passenger Passenger)
        {
            Passengers.Add(Passenger);
            return Passenger;
        }

        // PUT api/<PassengerController>/5
        [HttpPut("{id}")]
        public IEnumerable<Passenger> Put(int id, [FromBody] Passenger Passenger)
        {
            Passengers[id - 1] = Passenger;
            return Passengers;
        }

        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Passenger> Delete(int id)
        {
            Passengers.RemoveAt(id - 1);
            return Passengers;
        }
    }
}
