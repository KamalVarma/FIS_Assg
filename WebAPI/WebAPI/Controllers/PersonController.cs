using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Person")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{id=1,name="kamal",city="Pune"},
            new Person{id=2,name="varma",city="Mumbai"},
            new Person{id=3,name="RK",city="Jaipur"},
        };
        [HttpGet]
        [Route("PersonDetails")]

        public IEnumerable<Person> Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("personlist")]

        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,personlist);
            return response;
        }

        [Route("p")]
        public HttpResponseMessage GetP(int pid)
        {
            var person = personlist.Find(x => x.id == pid);
            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, pid);
            }
            return Request.CreateResponse(HttpStatusCode.OK, person);
        }

        //Post

        public Person POst([FromBody]Person p)
        {
            personlist.Add(p);
            return p;
        }
    }
}
