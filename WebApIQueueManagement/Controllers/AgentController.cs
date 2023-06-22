using ClassLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataBussinessLayer;
using System.Collections;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApIQueueManagement.Controllers
{
    public class AgentController : ApiController
    {
        public List<Info> Getinformation(string tokenno)
        {

            return AgentOperation.get_information(tokenno);
        }
        public OutResponse<int> Post(Agent agent)
        {
            OutResponse<int> outResponse= new OutResponse<int>();
            outResponse.ResData = 1;
            outResponse.ResMessage = "SuccessFully";
            outResponse.ResCode = 101;
            return outResponse;
        }
    }
}
