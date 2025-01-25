using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.ADOExample
{
    internal class ReaderExample
    {
        static void Main(string[] args)
        {
            String CS = @"data source = localhost\SQLEXPRESS;
                         database = ADOEXAMPLEDB;
                         trusted_connection = true;
                         trustservercertificate = true";

            SqlConnection connection = new SqlConnection(CS);

            string SqlQuery = $"Select DCode,Name from TDEPARTMENT";
            SqlCommand cmd = new SqlCommand(SqlQuery, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"Department Code : {Convert.ToString(reader["DCode"])} " +
                        $"Department Name : {reader["Name"].ToString()}"
                        );
                }
            }
            connection.Close();

            //reader is not available post connnection closed
        }
    }
}
