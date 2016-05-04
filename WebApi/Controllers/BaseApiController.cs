using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Data;

namespace WebApi.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        protected IDrivingTestContext Context { get; set; }
        public BaseApiController()
        {
            Context = new DrivingTestContext();
        }
        public BaseApiController(IDrivingTestContext context)
        {
            Context = context;
        }
        
    }
}