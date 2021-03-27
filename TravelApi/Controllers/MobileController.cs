using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TravelApi.Data;

namespace TravelApi.Controllers
{
    public class MobileController : ApiController
    {
        [Route("api/test")]
        [HttpGet]
        public HttpResponseMessage GetTest()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hi world");
        }

        [Route("api/getClients")]
        [HttpGet]
        public HttpResponseMessage GetClients()
        {
            var clients = Database.GetClients();
            return Request.CreateResponse(HttpStatusCode.OK, clients);
        }
    }
}