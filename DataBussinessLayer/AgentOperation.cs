using ClassLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataBussinessLayer
{
    public static class AgentOperation
    {
        public static List<QuestionAnswers> DisplayAnswer(string tokenno)
        {
            List<QuestionAnswers> q = DatabaseConnection.con.Query<QuestionAnswers>("exec GetAnswer @tokennumber ='" + tokenno + "'").ToList();
            return q;
        }
        public static List<Info> get_information(string tokenno)
        {
            List<Info> q = DatabaseConnection.con.Query<Info>("exec get_information @tokennumber ='" + tokenno + "'").ToList();
            return q;
        }
        
    }
}
