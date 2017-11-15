using AppraisalSystem.Web.EvaluationTemplateService;
using AppraisalSystem.Web.PositionService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppraisalSystem.Web.Admin
{
    public partial class EvaluationTemplates : System.Web.UI.Page
    {
        public EvaluationTemplates()
        {
            this.EvaluationTemplateService = new EvaluationTemplateWcfServiceClient();
            this.PositionService = new PositionWcfServiceClient();
        }

        public IEvaluationTemplateWcfService EvaluationTemplateService { get; set; }
        public IPositionWcfService PositionService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTemplates();
            }
        }

        public void BindTemplates()
        {
            IEnumerable<EvaluationTemplate> evaluationTemplates = this.EvaluationTemplateService.GetAllTemplates();

            this.dataTable.DataSource = evaluationTemplates;
            this.dataTable.DataBind();
        }

        protected void CreateTemplate_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateEvaluationTemplate");
        }
    }
}