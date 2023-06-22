using ClassLibraryEntity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessDataLayer
{
    public class UserOperation
    {
        public SqlConnection con = new SqlConnection(@"Data Source=PC-227\SQL2016EXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sagar;Password=aa");
        public List<QuestionAnswers> DisplayQuestion(int menuid)
        {
            List<QuestionAnswers> questionAnswers = con.Query<QuestionAnswers>("exec Ajay_Display_Question @menuid='" + menuid+"'").ToList();
            return questionAnswers;
        }
    }
}
