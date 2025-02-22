using EmployeePortal.DBEntity;
using EmployeePortal.DBEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal.Account
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            UserEntity user = new UserEntity()
            {
                EmailAddress = exampleInputEmail1.Value,
                FullName = exampleInputFullName.Value,
                Password = exampleInputPassword.Value,
            };

            EmployeeContext context = new EmployeeContext();
            var users = context.users.ToList();
            context.users.Add(user);
            context.SaveChanges();
            
        }
    }
}