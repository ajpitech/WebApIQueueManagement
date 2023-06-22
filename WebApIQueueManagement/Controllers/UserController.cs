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
    public class UserController : ApiController
    {
        //https://localhost:44372/Api/User/1
        public OutResponse<List<Questions>> Get(int id)
        {

            //OutResponse<List<Questions>> olt = new OutResponse<List<Questions>>();
            //olt.ResMessage = "Success";
            //olt.ResCode = 1;
            //olt.ResData = ;

            return UserOperation.DisplayQuestion(id);
             
        }
      
        public OutResponse<List<TokenCounter>> Post(int id, List<QuestionAnswers> QAList)
        {
            OutResponse<List<TokenCounter>> olt = new OutResponse<List<TokenCounter>>();
            olt.ResMessage = "Success";
            olt.ResCode = 1;
            olt.ResData=UserOperation.SaveToDatabase(id,  QAList);

            return olt;
        }

       
       
    }
}
