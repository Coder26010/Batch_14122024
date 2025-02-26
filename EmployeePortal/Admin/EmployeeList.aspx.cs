﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal.Admin
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["did"] != null)
            {
                lblDeptId.Text = Request.QueryString["did"].ToString();
            }
            else
            {
                Response.Redirect("~/Admin/Department.aspx");
            }
        }
    }
}