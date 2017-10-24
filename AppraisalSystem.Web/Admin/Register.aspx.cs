using AppraisalSystem.Web.AccountService;
using System;

namespace AppraisalSystem.Web.Admin
{
    public partial class Register : System.Web.UI.Page
    {
        private IAccountWcfService accountService;

        public Register()
        {
            this.accountService = new AccountWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Submit(object sender, EventArgs e)
        {
            this.accountService.CreateUser(this.FirstName.Text, this.LastName.Text, this.Password.Text, this.Email.Text);
        }
    }
}