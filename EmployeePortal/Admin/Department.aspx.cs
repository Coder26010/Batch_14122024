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
            if (!IsPostBack)
            {
                GridDepartment.DataSource = departmentRepository.GetDepartments;
                GridDepartment.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DepartmentModel department = new DepartmentModel()
            {
                Dcode = txtDepartmentCode.Text,
                Name = txtDepartmentName.Text,
                Desc = txtDepartmentDescription.Text
            };

            if (departmentRepository.Save(department, out string ErrorMessage))
            {
                ClearFormControls();
                GridDepartment.DataSource = departmentRepository.GetDepartments;
                GridDepartment.DataBind();
                ShowMessage("Success", "Record Created", MessageTyepe.success);
                //ClientScript.
                //    RegisterClientScriptBlock(this.GetType(),
                //    "success", "toastr[\"success\"](\"Record Created\", \"Success \")", true);

                //lblmsg.Text = "Record created.";
            }
            else
            {
                ShowMessage("Already Exists", "Record already exists", MessageTyepe.info);
                //ClientScript.
                //    RegisterClientScriptBlock(this.GetType(),
                //    "exists", "toastr[\"info\"](\"Record already exists\", \"Already Exists \")", true);
                //lblmsg.Text = "department code already exists.";
            }
        }



        #region Private Methods
        private void ClearFormControls()
        {
            txtDepartmentCode.Text = string.Empty;
            txtDepartmentDescription.Text = string.Empty;
            txtDepartmentName.Text = string.Empty;
        }

        private void ShowMessage(string Title, string Message, MessageTyepe MessageType)
        {
            Random random = new Random();
            string toastrMessage = $"toastr[\"{MessageType.ToString()}\"](\"{Message}\", \"{Title} \")";
            ClientScript.
                   RegisterClientScriptBlock(this.GetType(),
                   random.Next().ToString(), toastrMessage, true);

        }
        #endregion
    }


}