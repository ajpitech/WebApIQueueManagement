using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntity
{
    public static class DatabaseConnection
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=PC-227\SQL2016EXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sagar;Password=aa");
    }
}
