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
using System.Diagnostics.SymbolStore;

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

                int PageNo = 0;
                if (Request.QueryString["pageNo"] != null)
                    int.TryParse(Request.QueryString["pageNo"].ToString(), out PageNo);

                if(PageNo == 0)
                    PageNo = 1;

                var datalist = departmentRepository.GetDepartments(PageNo);
                int TotalRecord = datalist.FirstOrDefault().TotalRecord;
               

                if(TotalRecord > 0)
                {
                    int PageSize = 3;

                    int TotalPages = (int)Math.Ceiling((decimal)TotalRecord / PageSize);

                    List<Pager> Pager = new List<Pager>();
                    for (int i = 1; i <= TotalPages; i++)
                    {
                        Pager.Add(new Models.Pager() { 
                            PageNo = i,
                            PageUrl = $"~/Admin/Department.aspx?pageNo={i}"
                        });
                    }

                    rptPager.DataSource = Pager;
                    rptPager.DataBind();
                }

                GridDepartment.DataSource = datalist;
                GridDepartment.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int DepartmentId = 0;
            if(ViewState["hdfDepartmentId"] != null)
            {
                DepartmentId = Convert.ToInt32(ViewState["hdfDepartmentId"]);
            }
            //if (!(string.IsNullOrEmpty(hdfDepartmentId.Value)
            //    && string.IsNullOrWhiteSpace(hdfDepartmentId.Value)))
            //{
            //    DepartmentId = Convert.ToInt32(hdfDepartmentId.Value);
            //}

            DepartmentModel department = new DepartmentModel()
            {
                SystemNumber = DepartmentId,
                Dcode = txtDepartmentCode.Text,
                Name = txtDepartmentName.Text,
                Desc = txtDepartmentDescription.Text
            };

            if (departmentRepository.Save(department, out string ErrorMessage))
            {
                ClearFormControls();
                GridDepartment.DataSource = departmentRepository.GetDepartments();
                GridDepartment.DataBind();
                if (department.SystemNumber == 0)
                    ShowMessage("Success", "Record Created", MessageTyepe.success);
                else
                    ShowMessage("Success", "Record Updated", MessageTyepe.success);
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
            ViewState["hdfDepartmentId"] = null;
            //hdfDepartmentId.Value = null;
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

        protected void GridDepartment_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowindex = e.RowIndex;

            int DepartmentId = Convert.ToInt32(GridDepartment.DataKeys[rowindex].Value);

            if (departmentRepository.Remove(DepartmentId, out string ErrorMessage))
            {
                ShowMessage("Success", "Record removed successfully", MessageTyepe.success);
                GridDepartment.DataSource = departmentRepository.GetDepartments();
                GridDepartment.DataBind();
            }
            else
            {
                ShowMessage("Error", ErrorMessage, MessageTyepe.error);
            }
        }

        protected void GridDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DepartmentId = Convert.ToInt32(GridDepartment.DataKeys[GridDepartment.SelectedIndex].Value);
            //ShowMessage("Info",$"Selected Department Id - {DepartmentId}", MessageTyepe.info);
            DepartmentModel model = departmentRepository.GetDepartment(DepartmentId);

            if (model != null)
            {
                txtDepartmentCode.Text = model.Dcode;
                txtDepartmentName.Text = model.Name;
                txtDepartmentDescription.Text = model.Desc;
                if (ViewState["hdfDepartmentId"] == null)
                {
                    ViewState["hdfDepartmentId"] = model.SystemNumber.ToString();
                }
                //hdfDepartmentId.Value = model.SystemNumber.ToString();
            }
            else
            {
                ShowMessage("Info", $"Record not found", MessageTyepe.info);
            }
        }
    }


}