using ClassLibraryEntity;
using DataBussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApIQueueManagement.Controllers
{
    public class ServiceProviderController : ApiController
    {
        public List<ServiceBranchId> GetServiceBranchIds(int id)
        {
            return UserOperation.ServiceBranch(id);
        }
    }
}
