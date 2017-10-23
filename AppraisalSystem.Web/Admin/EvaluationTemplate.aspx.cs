using AppraisalSystem.Web.CompetenceService;
using AppraisalSystem.Web.PositionService;
using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class EvaluationTemplate : System.Web.UI.Page
    {
        private IQuestionWcfService questionService;
        private ICompetenceWcfService competenceService;
        private IPositionWcfService positionService;
        private string[] competences;
        private IEnumerable<QuestionService.Question> questions;

        public EvaluationTemplate()
        {
            this.questionService = new QuestionWcfServiceClient();
            this.competenceService = new CompetenceWcfServiceClient();
            this.positionService = new PositionWcfServiceClient();
            this.questions = new List<QuestionService.Question>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.competences = this.competenceService.GetAllCompetence();
            this.DropDownPositions.SelectedIndexChanged += new EventHandler(this.Selection_Change);
            this.DropDownListCompetences.SelectedIndexChanged += new EventHandler(this.Selection_Change);

            if (!IsPostBack)
            {
                var p = this.positionService.GetAll();
                this.DropDownPositions.DataSource = this.positionService.GetAll();
                this.DropDownPositions.DataBind();

                this.DropDownListCompetences.DataSource = competences;
                this.DropDownListCompetences.DataBind();
                this.DropDownListCompetences.Items.Add("Get all");

                //this.DropDownAddQuestion.DataSource = competences;
                //this.DropDownAddQuestion.DataBind();

                Bind();
            }
        }

        protected void Bind()
        {
            this.questions = this.questionService.GetQuestionByPositionAndCompetence(this.DropDownPositions.SelectedValue, this.DropDownListCompetences.SelectedValue);
            this.dataTable.DataSource = questions;
            this.dataTable.DataBind();
        }

        public void Selection_Change(Object sender, EventArgs e)
        {
            Bind();
        }

        private void ToggleElements(RepeaterItem item, bool isEdit)
        {
            //Edit
            item.FindControl("lnkEdit").Visible = !isEdit;
            item.FindControl("lblEdit").Visible = !isEdit;
            item.FindControl("txtEdit").Visible = isEdit;

            //Delete
            item.FindControl("lnkDelete").Visible = !isEdit;

            //Save
            item.FindControl("lnkSave").Visible = isEdit;

            //Cancel
            item.FindControl("lnkCancel").Visible = isEdit;
        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(item, true);
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            RepeaterItem item = ((LinkButton)sender).Parent as RepeaterItem;
            int questionId = int.Parse(((Label)item.FindControl("lblId")).Text.Trim());

            this.questionService.Delete(questionId);

            Bind();
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            RepeaterItem item = ((LinkButton)sender).Parent as RepeaterItem;
            string questionContent = ((TextBox)item.FindControl("txtEdit")).Text.Trim();
            int questionId = int.Parse(((Label)item.FindControl("lblId")).Text.Trim());

            this.questionService.UpdateQuestion(questionId, questionContent);

            Bind();
        }

        protected void lnkCancel_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(item, false);
        }

        protected void Submit_Question(object sender, EventArgs e)
        {
            string position = this.DropDownPositions.SelectedValue;
            string competence = this.DropDownListCompetences.SelectedValue;
            string content = this.txtAddQuestion.Text;

            this.questionService.AddQuestion(content, competence);
            this.txtAddQuestion.Text = null;

            Bind();
        }
    }
}