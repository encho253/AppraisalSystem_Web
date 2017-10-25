using AppraisalSystem.Web.AccountService;
using AppraisalSystem.Web.EvaluationService;
using System;
using System.Collections.Generic;

namespace AppraisalSystem.Web.Admin
{
    public partial class Evaluation : System.Web.UI.Page
    {
        private IEvaluationWcfService evaluationService;
        private IAccountWcfService accountService;

        public Evaluation()
        {
            this.evaluationService = new EvaluationWcfServiceClient();
            this.accountService = new AccountWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchUser_Click(object sender, EventArgs e)
        {
            var evaluators = this.evaluationService.GetAllEvaluatorsForEvaluation(this.txtAddUser.Text);
            this.dataTable.DataSource = evaluators;
            this.dataTable.DataBind();
        }

        protected void AddEvaluator_Click(object sender, EventArgs e)
        {

        }
    }
}