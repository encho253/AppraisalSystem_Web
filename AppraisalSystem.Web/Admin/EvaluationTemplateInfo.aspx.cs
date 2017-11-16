using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;

namespace AppraisalSystem.Web.Admin
{
    public partial class EvaluationTemplateInfo : System.Web.UI.Page
    {
        public EvaluationTemplateInfo()
        {
            this.QuestionService = new QuestionWcfServiceClient();
        }

        public IQuestionWcfService QuestionService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindQuestions();
            }
        }

        public void BindQuestions()
        {
            string queryParam = Request.QueryString["Id"];

            if (queryParam != null)
            {
                int evaluationTemplateId = Int32.Parse(queryParam);

                IEnumerable<Question> questions = this.QuestionService.GetAllQuestionsByEvaluationTemplate(evaluationTemplateId);

                this.dataTable.DataSource = questions;
                this.dataTable.DataBind();
            }            
        }
    }
}