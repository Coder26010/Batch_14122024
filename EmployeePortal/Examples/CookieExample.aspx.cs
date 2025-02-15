using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal.Examples
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["searchcookie"] != null)
            {
                HttpCookie searchcookie = Request.Cookies["searchcookie"];
                if(searchcookie["ProductName"] != null)
                {
                    txtName.Text = searchcookie["ProductName"].ToString();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie searchcookie = new HttpCookie("searchcookie");

            searchcookie["ProductName"] = txtName.Text;
            searchcookie["searchdatetime"] = System.DateTime.Now.ToString("ddMMyyyy:hh:mm:ss");
            searchcookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(searchcookie);
        }
    }
}