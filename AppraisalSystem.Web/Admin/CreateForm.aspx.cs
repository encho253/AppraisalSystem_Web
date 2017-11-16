using AppraisalSystem.Web.AccountService;
using AppraisalSystem.Web.EvaluationService;
using System;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class CreateForm : System.Web.UI.Page
    {
        private IEvaluationWcfService evaluationService;
        private IAccountWcfService accountService;

        public CreateForm()
        {
            this.evaluationService = new EvaluationWcfServiceClient();
            this.accountService = new AccountWcfServiceClient();
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
            var evaluators = this.evaluationService.GetAllEvaluatorsForEvaluation(1);
            this.dataTable.DataSource = evaluators;
            this.dataTable.DataBind();
        }

        protected void AddEvaluator_Click(object sender, EventArgs e)
        {
            RepeaterItem item = ((LinkButton)sender).Parent as RepeaterItem;
            string evaluator = ((TextBox)item.FindControl("txtAddEvaluator")).Text.Trim();

            this.evaluationService.AddEvaluatorToEvaluation(this.txtAddUser.Text.Trim(), evaluator);

            BindData();
        }
    }
}