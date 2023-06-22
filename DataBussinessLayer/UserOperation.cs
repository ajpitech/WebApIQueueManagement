using ClassLibraryEntity;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebApIQueueManagement.Controllers;

namespace DataBussinessLayer
{
    public static class UserOperation
    {
      
        public static List<QuestionAnswers> questionAnswers;
        public static OutResponse<List<Questions>> DisplayQuestion(int menuid)
        {
            OutResponse<List<Questions>> outResponse= new OutResponse<List<Questions>>();
            outResponse.ResMessage = "Succesful";
            outResponse.ResCode = 101;

            List<Questions> q = DatabaseConnection.con.Query<Questions>("exec Ajay_Display_Question @menuid='" + menuid+"'").ToList();
            outResponse.ResData= q;
            return outResponse;
        }
      
        public static List<TokenCounter> SaveToDatabase(int serviceBranchId, List<QuestionAnswers> QAList)
        {
            xml = new XElement("Root",
                  from Qa in QAList
                  select new XElement("Ansdetail",
                                     new XElement("QuestionId", Qa.QuestionId),
                                     new XElement("FullAnswer", Qa.FullAnswer)
                                 ));

            List<TokenCounter> tc=new List<TokenCounter>();
            tc = DatabaseConnection.con.Query<TokenCounter>("exec Create_TokenId '" + serviceBranchId + "','" + xml + "'").ToList();
            
            return tc;
        }
        //exec Create_TokenId '" + service_Branch_id + "','" + xml + "'
        public static XElement xml;
        //string query = " Ajay_sp_Service_Branch_Details @service_Branch_id="+s;
        public static List<ServiceBranchId> ServiceBranch(int id)
        {
           List<ServiceBranchId> sb = DatabaseConnection.con.Query<ServiceBranchId>("Ajay_sp_Service_Branch_Details @service_Branch_id="+id).ToList();

            return sb;
        }
        public static void ServingStatusChange (ServingStatus ss)
        {
            DatabaseConnection.con.Execute("Exec ajay_SeringStatusChange @TokenNumber = '"+ ss.Tokenno + "', @CounterId ='"+ss.CounterId + "', @statusId ='"+ss.statusid+"'");
        }
    }

}
