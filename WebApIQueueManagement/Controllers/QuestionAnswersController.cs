using Antlr.Runtime;
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
    public class QuestionAnswersController : ApiController
    {
        public List<QuestionAnswers> Get(string tokenno)
        {

            return AgentOperation.DisplayAnswer(tokenno);
        }
    }
}
