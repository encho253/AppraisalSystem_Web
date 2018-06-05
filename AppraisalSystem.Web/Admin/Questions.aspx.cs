using AppraisalSystem.Web.CompetenceService;
using AppraisalSystem.Web.PositionService;
using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class Questions : System.Web.UI.Page
    {
        private IQuestionWcfService questionService;
        private ICompetenceWcfService competenceService;
        private IPositionWcfService positionService;
        private IEnumerable<QuestionService.Question> questions;
        protected System.Web.UI.WebControls.Repeater PlayerRepeater;

        public Questions()
        {
            this.questionService = new QuestionWcfServiceClient();
            this.competenceService = new CompetenceWcfServiceClient();
            this.positionService = new PositionWcfServiceClient();
            this.questions = new List<QuestionService.Question>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.DropDownPositions.SelectedIndexChanged += new EventHandler(this.Selection_Change);
            IEnumerable<Position> positions = this.positionService.GetAllPositions();

            if (!IsPostBack)
            {
                this.DropDownPositions.DataSource = positions.Select(x => x.Name);
                this.DropDownPositions.DataBind();

                BindCompetences();
                BindQuestions();
            }
        }

        protected void BindQuestions()
        {
            IEnumerable<Position> positions = this.positionService.GetAllPositions();
            int positionId = SelectedPositionId(positions);

            var datasource = this.competenceService.GetAllCompetencesByPosition(positionId).Where(x => x.QuestionsCount > 0);
            this.dataTable.DataSource = datasource;
            this.dataTable.DataBind();
        }

        protected void BindCompetences()
        {
            IEnumerable<Position> positions = this.positionService.GetAllPositions();
            int positionId = SelectedPositionId(positions);

            var datasource = this.competenceService.GetAllCompetencesByPosition(positionId)
                                    .Select(x => new
                                    {
                                        x.Id,
                                        x.Key,
                                        x.QuestionsCount,
                                        DisplayField = String.Format("{0} ({1})", x.Key, x.QuestionsCount)
                                    })
                                    .OrderByDescending(p => p.QuestionsCount)
                                    .ThenBy(p => p.Key);

            this.DropDownCompetences.DataSource = datasource;
            this.DropDownCompetences.DataBind();
        }

        public void Selection_Change(Object sender, EventArgs e)
        {
            BindQuestions();
            BindCompetences();
        }

        public int SelectedPositionId(IEnumerable<Position> positions)
        {
            string selectedPosition = this.DropDownPositions.SelectedValue;
            int positionId = positions
                .FirstOrDefault(x => x.Name == selectedPosition)
                .Id;

            return positionId;
        }

        override protected void OnInit(EventArgs e)
        {
            InitializeComponent();
            base.OnInit(e);
        }

        private void InitializeComponent()
        {
            this.dataTable.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.CategoryRepeater_ItemDataBound);
            this.Load += new System.EventHandler(this.Page_Load);

        }

        private void CategoryRepeater_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            
            IEnumerable<Position> positions = this.positionService.GetAllPositions();
            int positionId = SelectedPositionId(positions);
          
            if ((item.ItemType == ListItemType.Item) ||
                (item.ItemType == ListItemType.AlternatingItem))
            {
                PlayerRepeater = (Repeater)item.FindControl("PlayerRepeater");
                string competenceKey = ((Label)item.FindControl("Label1")).Text.Trim();

                var datasource = this.competenceService.GetAllCompetencesByPosition(positionId).Where(x => x.QuestionsCount > 0 && x.Key == competenceKey);

                PlayerRepeater.DataSource = datasource.First().Questions;
                PlayerRepeater.DataBind();
            }
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

            BindQuestions();
            BindCompetences();
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            RepeaterItem item = ((LinkButton)sender).Parent as RepeaterItem;
            string questionContent = ((TextBox)item.FindControl("txtEdit")).Text.Trim();
            int questionId = int.Parse(((Label)item.FindControl("lblId")).Text.Trim());

            this.questionService.UpdateQuestion(questionId, questionContent);

            BindQuestions();
        }

        protected void lnkCancel_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(item, false);
        }

        protected void Submit_Question(object sender, EventArgs e)
        {
            string position = this.DropDownPositions.SelectedValue;
            int competenceId = Int32.Parse(this.DropDownCompetences.SelectedValue);
            string content = this.txtAddQuestion.Text;

            this.questionService.AddQuestion(content, position, competenceId);
            this.txtAddQuestion.Text = null;

            BindQuestions();
            BindCompetences();
        }
    }
}