using AppraisalSystem.Web.EvaluationService;
using System;
using System.Collections.Generic;

namespace AppraisalSystem.Web.Admin
{
    public partial class EvaluationTemplate : System.Web.UI.Page
    {
        private IEvaluationWcfService evaluationService;
        //private IAccountWcfService accountService;

        public EvaluationTemplate()
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
            IEnumerable<Evaluation> evaluations = this.evaluationService.GetAllEvaluationsForUser(this.txtAddUser.Text.Trim());
            this.dataTable.DataSource = evaluations;
            this.dataTable.DataBind();
        }

        protected void AddEvaluator_Click(object sender, EventArgs e)
        {
        }
    }
}