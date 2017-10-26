using AppraisalSystem.Web.CompetenceService;
using AppraisalSystem.Web.PositionService;
using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;

namespace AppraisalSystem.Web.Admin
{
    public partial class Competences : System.Web.UI.Page
    {
        private IQuestionWcfService questionService;
        private ICompetenceWcfService competenceService;
        private IPositionWcfService positionService;
        private IEnumerable<QuestionService.Question> questions;

        public Competences()
        {
            this.positionService = new PositionWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.DropDownPositions.SelectedIndexChanged += new EventHandler(this.Selection_Change);

            //if (!IsPostBack)
            //{
            //    this.DropDownPositions.DataSource = this.positionService.GetAll();
            //    this.DropDownPositions.DataBind();

            //    this.DropDownListCompetences.DataSource = competences;
            //    this.DropDownListCompetences.DataBind();
            //    this.DropDownListCompetences.Items.Add("Get all");

            //    //this.DropDownAddQuestion.DataSource = competences;
            //    //this.DropDownAddQuestion.DataBind();

            //    Bind();
            //}
        }

        protected void Bind()
        {
            //this.questions = this.questionService.GetQuestionByPositionAndCompetence(this.DropDownPositions.SelectedValue, this.DropDownListCompetences.SelectedValue);
            //this.dataTable.DataSource = questions;
            //this.dataTable.DataBind();
        }
    }
}