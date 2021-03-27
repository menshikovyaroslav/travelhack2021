﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace TravelApi.Controllers
{
    public class MobileController : ApiController
    {
        [Route("api/{test}")]
        [HttpGet]
        public HttpResponseMessage GetTest(string test)
        {
            return Request.CreateResponse(HttpStatusCode.OK, test);
        }
    }
}