using AppraisalSystem.Web.EvaluationService;
using System;

namespace AppraisalSystem.Web.Admin
{
    public partial class Evaluation : System.Web.UI.Page
    {
        private IEvaluationWcfService evaluationService;
        //private IAccountWcfService accountService;

        public Evaluation()
        {
            this.evaluationService = new EvaluationWcfServiceClient();
            //this.accountService = new AccountWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchUser_Click(object sender, EventArgs e)
        {
            BindData();
        }
     
        public void BindData()
        {
            var evaluations = this.evaluationService.GetAllEvaluationsForUser(this.txtAddUser.Text.Trim());
            this.dataTable.DataSource = evaluations;
            this.dataTable.DataBind();
        }

        protected void AddEvaluator_Click(object sender, EventArgs e)
        {
        }
    }
}