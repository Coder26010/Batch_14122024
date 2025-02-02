using EmployeePortal.Admin;
using EmployeePortal.AppConstatnt;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EmployeePortal.Repostitory
{
    public class DepartmentRepository
    {
        string CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        public bool Save(DepartmentModel model, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    SqlCommand command = new SqlCommand(StoredProcedure.InsertDepartment, conn);
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

        public List<DepartmentModel> GetDepartments
        {
            get
            {
                try
                {
                    List<DepartmentModel> departments = new List<DepartmentModel>();
                    using (SqlConnection conn = new SqlConnection(CS))
                    {
                        SqlCommand command = new SqlCommand(StoredProcedure.GetAllDepartment, conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //DepartmentModel model = new DepartmentModel()
                                //{
                                //    SystemNumber = Convert.ToInt32(reader["SystemNumber"]),
                                //    Dcode = reader["DCode"].ToString(),
                                //    Name = reader["Name"].ToString(),
                                //    CreateDateTime = Convert.ToDateTime(reader["RecordCreationDate"])
                                //};
                                //departments.Add(model);

                                departments.Add(new DepartmentModel()
                                {
                                    SystemNumber = Convert.ToInt32(reader["SystemNumber"]),
                                    Dcode = reader["DCode"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    CreateDateTime = Convert.ToDateTime(reader["RecordCreationDate"])
                                });
                            }
                        }
                        conn.Close();
                    }
                    return departments;
                }
                catch (Exception)
                {
                    return new List<DepartmentModel>();
                }
            }
        }

        public bool Remove(int DepartmentId, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CS))
                {
                    SqlCommand command = new SqlCommand(StoredProcedure.DeleteDepartment, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@SystemNumber", DepartmentId);

                    conn.Open();
                    int row = command.ExecuteNonQuery();
                    conn.Close();

                    if (row > 0)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "System unable to perform this action";
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