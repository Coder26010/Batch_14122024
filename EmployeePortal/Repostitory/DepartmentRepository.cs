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
using EmployeePortal.DBEntity;
using EmployeePortal.DBEntity.Entity;
using System.Data.Entity.Infrastructure;

namespace EmployeePortal.Repostitory
{
    public class DepartmentRepository
    {
        private readonly EmployeeContext context;
        string CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        public DepartmentRepository()
        {
            context = new EmployeeContext();
        }

        public bool Save(DepartmentModel model, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {
                if (model.SystemNumber > 0)
                    return Update(model, out ErrorMessage);

                DEPARTMENTENTITY dEPARTMENTENTITY = new DEPARTMENTENTITY()
                {
                    Name = model.Name,
                    DepartmentCode = model.Dcode,
                    Description = model.Desc
                };

                context.Departments.Add(dEPARTMENTENTITY);
                context.SaveChanges();

                if (dEPARTMENTENTITY.Id > 0)
                    return true;
                else
                    ErrorMessage = "department code already exists.";

                //using (SqlConnection conn = new SqlConnection(CS))
                //{
                //    SqlCommand command = new SqlCommand(StoredProcedure.InsertDepartment, conn);
                //    command.CommandType = System.Data.CommandType.StoredProcedure;
                //    command.Parameters.Clear();
                //    command.Parameters.AddWithValue("@Dcode", model.Dcode);
                //    command.Parameters.AddWithValue("@Name", model.Name);
                //    command.Parameters.AddWithValue("@Des", model.Desc);

                //    conn.Open();
                //    string status = (string)command.ExecuteScalar();
                //    conn.Close();

                //    if (status == "create")
                //    {
                //        return true;
                //    }
                //    else
                //    {
                //        ErrorMessage = "department code already exists.";
                //    }
                //}

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DepartmentModel> GetDepartments(int PageNo = 1, int PageSize = 3)
        {

            try
            {
                var data = context.Departments;
                int TotalCount = data.Count();

                return data.OrderBy(x => x.Id)
                   .Skip((PageNo - 1) * PageSize).Take(PageSize)
                   .Select(x => new DepartmentModel()
                   {
                       SystemNumber = x.Id,
                       Dcode = x.DepartmentCode,
                       Name = x.Name,
                       Desc = x.Description,
                       CreateDateTime = x.RecordCreationDate,
                       TotalRecord = TotalCount
                   })
                   .ToList();

                //foreach (var item in departmentlist)
                //{
                //    departments.Add(new DepartmentModel()
                //    {
                //        SystemNumber = item.Id,
                //        Dcode = item.DepartmentCode,
                //        Name = item.Name,
                //        Desc = item.Description,
                //        CreateDateTime = item.RecordCreationDate,
                //        TotalRecord = TotalCount
                //    });
                //}

                //using (SqlConnection conn = new SqlConnection(CS))
                //{
                //    SqlCommand command = new SqlCommand(StoredProcedure.GetAllDepartment, conn);
                //    command.CommandType = System.Data.CommandType.StoredProcedure;

                //    command.Parameters.AddWithValue("@PageSize", PageSize);
                //    command.Parameters.AddWithValue("@PageNo", PageNo);

                //    conn.Open();
                //    SqlDataReader reader = command.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        while (reader.Read())
                //        {
                //            departments.Add(new DepartmentModel()
                //            {
                //                SystemNumber = Convert.ToInt32(reader["SystemNumber"]),
                //                Dcode = reader["DCode"].ToString(),
                //                Name = reader["Name"].ToString(),
                //                CreateDateTime = Convert.ToDateTime(reader["RecordCreationDate"]),
                //                TotalRecord = Convert.ToInt32(reader["TotalRecords"]),
                //            });
                //        }
                //    }
                //    conn.Close();
                //}

            }
            catch (Exception)
            {
                return new List<DepartmentModel>();
            }

        }

        public DepartmentModel GetDepartment(int DepartmentId)
        {

            try
            {
                DEPARTMENTENTITY dEPARTMENTENTITY = context.Departments.Find(DepartmentId);

                if(dEPARTMENTENTITY != null)
                {
                    return new DepartmentModel()
                    {
                        SystemNumber = dEPARTMENTENTITY.Id,
                        Dcode = dEPARTMENTENTITY.DepartmentCode,
                        Name = dEPARTMENTENTITY.Name,
                        Desc = dEPARTMENTENTITY.Description
                    };
                }
                else
                {
                    return null;
                }

                //DepartmentModel departments = null;
                //using (SqlConnection conn = new SqlConnection(CS))
                //{
                //    SqlCommand command = new SqlCommand(StoredProcedure.GetDepartment, conn);
                //    command.CommandType = System.Data.CommandType.StoredProcedure;
                //    command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                //    conn.Open();
                //    SqlDataReader reader = command.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        while (reader.Read())
                //        {
                //            departments = new DepartmentModel()
                //            {
                //                SystemNumber = Convert.ToInt32(reader["SystemNumber"]),
                //                Dcode = reader["DCode"].ToString(),
                //                Name = reader["Name"].ToString(),
                //                Desc = reader["Description"].ToString()
                //            };
                //        }
                //    }
                //    conn.Close();
                //}
                //return departments;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool Remove(int DepartmentId, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {
                DEPARTMENTENTITY dEPARTMENTENTITY = context.Departments.Find(DepartmentId);
                if(dEPARTMENTENTITY != null)
                {
                    context.Departments.Remove(dEPARTMENTENTITY);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    ErrorMessage = "Record not found.";
                    return false;
                }

                //using (SqlConnection conn = new SqlConnection(CS))
                //{
                //    SqlCommand command = new SqlCommand(StoredProcedure.DeleteDepartment, conn);
                //    command.CommandType = System.Data.CommandType.StoredProcedure;
                //    command.Parameters.Clear();
                //    command.Parameters.AddWithValue("@SystemNumber", DepartmentId);

                //    conn.Open();
                //    int row = command.ExecuteNonQuery();
                //    conn.Close();

                //    if (row > 0)
                //    {
                //        return true;
                //    }
                //    else
                //    {
                //        ErrorMessage = "System unable to perform this action";
                //    }
                //}

                //return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DepartmentModel model, out string ErrorMessage)
        {
            ErrorMessage = string.Empty;
            try
            {

                if(!context.Departments.Any(x => x.Id != model.SystemNumber && x.DepartmentCode == model.Dcode))
                {
                    DEPARTMENTENTITY dEPARTMENTENTITY = context.Departments.Find(model.SystemNumber);

                    if (dEPARTMENTENTITY == null)
                    {
                        dEPARTMENTENTITY.Name = model.Name;
                        dEPARTMENTENTITY.DepartmentCode = model.Dcode;
                        dEPARTMENTENTITY.Description = model.Desc;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "department not found";
                        return false;
                    }
                }
                else
                {
                    ErrorMessage = "department code already exists.";
                    return false;
                }

               
                

                //using (SqlConnection conn = new SqlConnection(CS))
                //{
                //    SqlCommand command = new SqlCommand(StoredProcedure.UpdateDepartment, conn);
                //    command.CommandType = System.Data.CommandType.StoredProcedure;
                //    command.Parameters.Clear();
                //    command.Parameters.AddWithValue("@DepartmentId", model.SystemNumber);
                //    command.Parameters.AddWithValue("@DepartmentCode", model.Dcode);
                //    command.Parameters.AddWithValue("@DepartmentName", model.Name);
                //    command.Parameters.AddWithValue("@Description", model.Desc);

                //    conn.Open();
                //    string status = (string)command.ExecuteScalar();
                //    conn.Close();

                //    if (status == "updated")
                //    {
                //        return true;
                //    }
                //    else
                //    {
                //        ErrorMessage = "department code already exists.";
                //    }
                //}

                //return false;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}