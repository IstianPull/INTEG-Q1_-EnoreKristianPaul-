using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using BMSYS.DL;

namespace BMSYS.DAL
{
    public class SqlData
    {
        static string connectionString = "Data Source=DESKTOP-Q5DOQT6;Initial Catalog=BMSYS;Persist Security Info=True;User ID=sa;Password=***********";
        
        static SqlConnection sqlConnection = new SqlConnection(connectionString);// not done yet

    }
}
