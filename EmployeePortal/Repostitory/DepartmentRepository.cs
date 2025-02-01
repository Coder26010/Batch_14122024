using EmployeePortal.Admin;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeePortal.Repostitory
{
    public class DepartmentRepository
    {
        string CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        public bool Save(DepartmentModel model,out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    SqlCommand command = new SqlCommand("spInsertDepartment", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Dcode", model.Dcode);
                    command.Parameters.AddWithValue("@Name", model.Name);
                    command.Parameters.AddWithValue("@Des", model.Desc);

                    conn.Open();
                    string status = (string)command.ExecuteScalar();
                    conn.Close();

                    if (status == "create")
                    {
                       return true;
                    }
                    else
                    {
                        ErrorMessage = "department code already exists.";
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}