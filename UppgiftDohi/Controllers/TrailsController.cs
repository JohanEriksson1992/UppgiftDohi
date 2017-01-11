using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UppgiftDohi.Models;

namespace UppgiftDohi.Controllers
{
        
    public class TrailsController : ApiController
    {

        List<Trail> trails = Trail.GenerateList();


        // GET: api/Trails
        public IEnumerable<Trail> Get()
        {
            return trails;
        }

        // GET: api/Trails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Trails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Trails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Trails/5
        public void Delete(int id)
        {
        }

    }

    
}
