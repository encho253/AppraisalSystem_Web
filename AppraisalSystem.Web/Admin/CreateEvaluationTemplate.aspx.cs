using AppraisalSystem.Web.EvaluationTemplateService;
using AppraisalSystem.Web.PositionService;
using AppraisalSystem.Web.QuestionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class CreateEvaluationTemplate : System.Web.UI.Page
    {
        public CreateEvaluationTemplate()
        {
            this.EvaluationTemplateService = new EvaluationTemplateWcfServiceClient();
            this.PositionService = new PositionWcfServiceClient();
            this.QuestionService = new QuestionWcfServiceClient();
        }

        public IEvaluationTemplateWcfService EvaluationTemplateService { get; set; }
        public IPositionWcfService PositionService { get; set; }
        public IQuestionWcfService QuestionService { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DropDownPositions.SelectedIndexChanged += new EventHandler(this.Selection_Change);

            if (!IsPostBack)
            {
                //BindTemplates();
                PositionBind();
                QuestionBind();
            }       
        }

        private void Selection_Change(object sender, EventArgs e)
        {
            QuestionBind();
        }

        //public void BindTemplates()
        //{
        //    IEnumerable<EvaluationTemplate> evaluationTemplates = this.EvaluationTemplateService.GetAllTemplates();

        //    this.dataTable.DataSource = evaluationTemplates;
        //    this.dataTable.DataBind();
        //}

        public void PositionBind()
        {
            IEnumerable<Position> positions = this.PositionService.GetAllPositions()
                .Select(x => new Position { Id = x.Id, Name = x.Name})
                .ToList();

            this.DropDownPositions.DataValueField = "Id";
            this.DropDownPositions.DataTextField = "Name";
            this.DropDownPositions.DataSource = positions;
            this.DropDownPositions.DataBind();
        }

        public void QuestionBind()
        {
            IEnumerable<Question> questions = this.QuestionService.GetByPosition(this.DropDownPositions.SelectedItem.Text.Trim());

            this.dataTable.DataSource = questions;
            this.dataTable.DataBind();
        }

        protected void CreateEvalTemplate(object sender, EventArgs e)
        {
            List<int> questionContents = new List<int>();

            for (int i = 0; i < this.dataTable.Items.Count; i++)
            {
                CheckBox checkBox = (CheckBox)this.dataTable.Items[i].FindControl("CheckBox");

                if (checkBox.Checked)
                {
                    Label label = (Label)this.dataTable.Items[i].FindControl("LabelId");
                    questionContents.Add(Int32.Parse(label.Text));
                }
            }

            var fsd = this.DropDownPositions.SelectedItem;

            int positionId = Int32.Parse(this.DropDownPositions.SelectedValue);
            string templateName = this.TemplateName.Text.Trim();

            this.EvaluationTemplateService.CreateEvaluationTemplate(positionId, templateName, questionContents.ToArray());
        }
    }
}