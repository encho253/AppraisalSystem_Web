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
            }

            QuestionBind();
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
            IEnumerable<Position> positions = this.PositionService.GetAllPositions();
            IEnumerable<string> positionNames = positions.Select(x => x.Name);
            this.DropDownPositions.DataSource = positionNames;
            this.DropDownPositions.DataBind();
        }

        public void QuestionBind()
        {
            IEnumerable<Question> questions = this.QuestionService.GetByPosition(this.DropDownPositions.SelectedValue.Trim());

            this.dataTable.DataSource = questions;
            this.dataTable.DataBind();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            List<String> df = new List<string>();

            for (int i = 0; i < this.dataTable.Items.Count; i++)
            {
                CheckBox checkBox = (CheckBox)this.dataTable.Items[i].FindControl("CheckBox");

                if (checkBox.Checked)
                {
                    df.Add(checkBox.Text);
                }
            }
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}