using System;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp_Batch_11_30_to_1.ADOExample
{
    internal class AdapterExample
    {
        static void Main(string[] args)
        {
            String CS = @"data source = localhost\SQLEXPRESS;
                         database = ADOEXAMPLEDB;
                         trusted_connection = true;
                         trustservercertificate = true";

            //SqlConnection connection = new SqlConnection(CS);
            //connection.Open();
            //Console.WriteLine("System Connected with DB Server.");
            //connection.Close();

            string Query = @"Select DCode,Name from TDEPARTMENT;
                             Select DCode,Name,RecordCreationDate from TDEPARTMENT;";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, CS);

            //DataTable dt = new DataTable("TDEPARTMENT");
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count > 0)
            {
                foreach (DataTable table in dataSet.Tables)
                {
                    if (table.Rows.Count > 0)
                    {
                        if (table.Columns.Contains("RecordCreationDate"))
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                Console.WriteLine(
                                   $"Department Code : {Convert.ToString(row[0])} " +
                                   $"Department Name : {row["Name"].ToString()} " +
                                   $"Created On : {row["RecordCreationDate"].ToString()}"
                                   );
                            }
                        }
                        else
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                Console.WriteLine(
                                   $"Department Code : {Convert.ToString(row[0])} " +
                                   $"Department Name : {row["Name"].ToString()}"
                                   );
                            }

                        }

                        Console.WriteLine("--------------------------------------");
                    }
                }
            }

            //if(dt.Rows.Count > 0)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        Console.WriteLine(
            //           $"Department Code : {Convert.ToString(row[0])} " +
            //           $"Department Name : {row["Name"].ToString()}"
            //           );
            //    }
            //}

        }
    }
}
