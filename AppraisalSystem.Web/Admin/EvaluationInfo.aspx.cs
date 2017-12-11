using AppraisalSystem.Web.EvaluationService;
using AppraisalSystem.Web.EvaluationTemplateService;
using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;

namespace AppraisalSystem.Web.Admin
{
    public partial class EvaluationInfo : System.Web.UI.Page
    {
        private IEvaluationWcfService evaluationService;
        private IEvaluationTemplateWcfService evaluationTemplateService;
        private IQuestionWcfService questionService;

        public EvaluationInfo()
        {
            this.evaluationService = new EvaluationWcfServiceClient();
            this.questionService = new QuestionWcfServiceClient();
            this.evaluationTemplateService = new EvaluationTemplateWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindEvaluatorsData();
            BindQuestions();
        }

        public void BindEvaluatorsData()
        {
            string queryParam = Request.QueryString["Id"];

            if (queryParam != null)
            {
                int evaluationId = Int32.Parse(queryParam);

                IEnumerable<User> evaluators = this.evaluationService.GetAllEvaluatorsForEvaluation(evaluationId);

                this.EvaluatorsRepeater.DataSource = evaluators;
                this.EvaluatorsRepeater.DataBind();
            }
        }

        public void BindQuestions()
        {
            string queryParam = Request.QueryString["Id"];          

            if (queryParam != null)
            {
                int evaluationId = Int32.Parse(queryParam);

                var evaluation = this.evaluationService.GetEvaluationById(evaluationId);

                IEnumerable<Question> questions = this.questionService.GetAllQuestionsByEvaluationTemplate(evaluation.EvaluationTemplateId);
                var evaluationTemplate = this.evaluationTemplateService.GetEvaluationTemplateById(evaluation.EvaluationTemplateId);
                this.LabelName.Text = evaluationTemplate.Name;

                this.QuestionsRepeater.DataSource = questions;
                this.QuestionsRepeater.DataBind();
            }
        }

        protected void AddEvaluator_Click(object sender, EventArgs e)
        {

        }
    }
}