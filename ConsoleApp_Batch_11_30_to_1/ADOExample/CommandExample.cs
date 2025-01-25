using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ADOExample
{
    //This class demonstrat how the application Interact with DB
    internal class CommandExample
    {
        static void Main(string[] args)
        {
            String CS = @"data source = localhost\SQLEXPRESS;
                         database = ADOEXAMPLEDB;
                         trusted_connection = true;
                         trustservercertificate = true";

            SqlConnection connection = new SqlConnection(CS);
            //connection.ConnectionString = CS;

            String DCODE = "HR";
            String Name = "Human Resource";

            string SqlQuery = $"INSERT INTO TDEPARTMENT (DCode,Name) " +
                              $"Values('{DCODE}','{Name}')";

            SqlCommand cmd = new SqlCommand(SqlQuery, connection);

            //cmd.CommandText = "Delete from TDEPARTMENT where DCode like 'TEST%';";

            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine($"{rows} row(s) inserted");
        }
    }
}
