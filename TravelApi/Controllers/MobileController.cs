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

        [Route("api/getUsers")]
        [HttpGet]
        public HttpResponseMessage GetUsers()
        {
            var users = Database.GetUsers();
            return Request.CreateResponse(HttpStatusCode.OK, users);
        }

        [Route("api/getUser/{userId}")]
        [HttpGet]
        public HttpResponseMessage GetUserById(int userId)
        {
            var user = Database.GetUserById(userId);

            if (user == null) return Request.CreateResponse(HttpStatusCode.NotFound);
            else return Request.CreateResponse(HttpStatusCode.OK, user);
        }
    }
}