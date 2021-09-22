﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TRMDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            return new string[] { "value1", "value2", userId };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}