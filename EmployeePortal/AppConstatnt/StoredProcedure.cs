using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.AppConstatnt
{
    public static class StoredProcedure
    {
        #region "All Stored Procedure related to Department"

        public static string InsertDepartment = "spInsertDepartment";

        public static string GetAllDepartment = "spGetAllDepartments";
        public static string GetDepartment = "spGetDepartment";

        public static string DeleteDepartment = "spDeleteDepartment";

        public static string UpdateDepartment = "spUpdateDepartment";

        #endregion

        #region "All Stored Procedure related to Employee"

        #endregion

        #region "All Stored Procedure related to Reports"

        #endregion
    }
}