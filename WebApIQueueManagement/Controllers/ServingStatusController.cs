using DataBussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApIQueueManagement.Controllers
{
    public class ServingStatusController : ApiController
    {
        public int Post(ServingStatus tcs)
        {
            UserOperation.ServingStatusChange(tcs);
            return 1;
        }
    }
}
