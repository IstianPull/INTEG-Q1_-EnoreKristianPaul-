using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using BMSYS.DL;
using DevExpress.Xpo.DB;

namespace BMSYS.DAL
{
    public class SqlData
    {
        static string connectionString = "Data Source=DESKTOP-Q5DOQT6;Initial Catalog=BMSYS;Persist Security Info=True;User ID=sa;Password=***********";
        
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        static public bool ValidateAdmin(string username , string password) 
        {
            var selectStatement = "SELECT * FROM [BSMSYS].[dbo].[Admin] WHERE username = @username AND password = @password";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection );
            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", username);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var authorizePersonel = reader.Read();
            sqlConnection.Close();


            return authorizePersonel; // not done yet
        }



    }
}
