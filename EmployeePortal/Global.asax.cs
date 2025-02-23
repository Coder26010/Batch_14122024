using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Principal;

namespace EmployeePortal
{
   
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["TotalLoad"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["TotalLoad"] = Convert.ToInt32(Application["TotalLoad"]) + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            if(cookie != null)
            {
                string encryptedTicket = cookie.Value;
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(encryptedTicket);
               
                if(DateTime.Now < ticket.Expiration)
                {
                    string userName = ticket.Name;
                    string userRoles = ticket.UserData;
                    string[] roles = userRoles.Split(',');
                    GenericIdentity identity = new GenericIdentity(userName);
                    GenericPrincipal principal = new GenericPrincipal(identity, roles);
                    HttpContext.Current.User = principal;
                }
            }

            
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["TotalLoad"] = Convert.ToInt32(Application["TotalLoad"]) - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}