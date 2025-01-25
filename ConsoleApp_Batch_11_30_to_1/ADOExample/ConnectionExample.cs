using System;

using System.Data.SqlClient;

namespace ConsoleApp_Batch_11_30_to_1.ADOExample
{
    //This class demonstrat how the application  estabilish the connection with DB
    internal class ConnectionExample
    {
        static void Main(string[] args)
        {
            String CS = @"data source = localhost\SQLEXPRESS;
                         database = ADOEXAMPLEDB;
                         trusted_connection = true;
                         trustservercertificate = true";

            SqlConnection connection = new SqlConnection(CS);
            //connection.ConnectionString = CS;
            connection.Open();
            Console.WriteLine("System Connected with DB Server.");
            connection.Close();

        }
    }
}
