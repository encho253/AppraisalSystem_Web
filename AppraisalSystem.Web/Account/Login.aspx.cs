using System;
using System.Web.UI;
using System.Web.Security;

namespace AppraisalSystem.Web.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(UserName.Text, Password.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, false);
            }
            else
            {
                FailureText.Text = "Invalid login!";
            }
        }
    }
}