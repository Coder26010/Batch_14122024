using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using EmployeePortal.Models;
using EmployeePortal.Repostitory;

namespace EmployeePortal.Admin
{
    public partial class Department : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["EMPDBCON"].ConnectionString;
        private readonly DepartmentRepository departmentRepository;

        public Department()
        {
             departmentRepository = new DepartmentRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DepartmentModel department = new DepartmentModel()
            {
                Dcode = txtDepartmentCode.Text,
                Name = txtDepartmentName.Text,
                Desc = txtDepartmentDescription.Text
            };
           
            if(departmentRepository.Save(department,out string ErrorMessage))
            {
                ClearFormControls();
                lblmsg.Text = "Record created.";
            }
            else
            {
                lblmsg.Text = "department code already exists.";
            }
        }

        private void ClearFormControls()
        {
            txtDepartmentCode.Text = string.Empty;
            txtDepartmentDescription.Text = string.Empty;
            txtDepartmentName.Text = string.Empty;
        }
    }
}