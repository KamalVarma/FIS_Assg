using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> mystrings = new List<string> { "value0", "value1", "value2" };

        public IEnumerable<string> Get()
        {
            return mystrings;
        }

        public string Get(int id)
        {
            return mystrings[id];
        }

        public IEnumerable<string> Post([FromUri] Class1 val)
        {
            mystrings.Add(val.name);
            return mystrings;
        }

        //public IEnumerable<string> post([FromBody] string val)
        //{
        //    mystrings.Add(val);
        //    return mystrings;
        //}

        public IEnumerable<string> Put(int id,[FromUri]string val)
        {
            mystrings[id - 1] = val;
            return mystrings;
        }
    }
}
