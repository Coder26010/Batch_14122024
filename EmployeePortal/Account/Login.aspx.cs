using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using EmployeePortal.DBEntity;
using EmployeePortal.DBEntity.Entity;

namespace EmployeePortal.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string UserId = exampleInputEmail1.Value;
            string pswd = exampleInputPassword.Value;
            UserEntity user = new EmployeeContext().users.FirstOrDefault(x => x.EmailAddress == UserId && x.Password == pswd);
            if (user != null)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,user.EmailAddress,
                    DateTime.Now, DateTime.Now.AddMinutes(30), false, user.Roles);

                string encryptedTicket = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Admin/Department.aspx");
                return;
            }

            ShowMessage("Faild", "Incorrect userid or password", MessageTyepe.error);
        }

        private void ShowMessage(string Title, string Message, MessageTyepe MessageType)
        {
            Random random = new Random();
            string toastrMessage = $"toastr[\"{MessageType.ToString()}\"](\"{Message}\", \"{Title} \")";
            ClientScript.
                   RegisterClientScriptBlock(this.GetType(),
                   random.Next().ToString(), toastrMessage, true);

        }
    }
}