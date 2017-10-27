using AppraisalSystem.Web.CompetenceService;
using AppraisalSystem.Web.PositionService;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class Competences : System.Web.UI.Page
    {
        private ICompetenceWcfService competenceService;
        private IPositionWcfService positionService;

        public Competences()
        {
            this.competenceService = new CompetenceWcfServiceClient();
            this.positionService = new PositionWcfServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        public void Bind()
        {
            IEnumerable<Competence> competences = competenceService.GetAllCompetences();
            this.dataTable.DataSource = competences;
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

        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {

        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {

        }

        protected void lnkCancel_Click(object sender, EventArgs e)
        {

        }

        protected void AddCompetence_Click(object sender, EventArgs e)
        {
            string competenceName = this.txtAddCompetence.Text.Trim();

            this.competenceService.AddCompetence(competenceName);
            this.txtAddCompetence.Text = null;

            Bind();
        }
    }
}