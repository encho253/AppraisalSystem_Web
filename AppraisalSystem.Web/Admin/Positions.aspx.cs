using AppraisalSystem.Web.PositionService;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace AppraisalSystem.Web.Admin
{
    public partial class Positions : System.Web.UI.Page
    {
        //private IQuestionWcfService questionService;
        //private ICompetenceWcfService competenceService;
        //private IEnumerable<Question> questions;
        private IPositionWcfService positionService;

        public Positions()
        {
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
            IEnumerable<Position> positions = positionService.GetAllPositions();
            this.dataTable.DataSource = positions;
            this.dataTable.DataBind();
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

        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            RepeaterItem item = ((LinkButton)sender).Parent as RepeaterItem;
            string positionName = ((TextBox)item.FindControl("txtEdit")).Text.Trim();
            int positionId = int.Parse(((Label)item.FindControl("lblId")).Text.Trim());

            this.positionService.UpdatePosition(positionId, positionName);

            Bind();
        }

        protected void lnkCancel_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            this.ToggleElements(item, false);
        }

        protected void AddPosition_Click(object sender, EventArgs e)
        {
            string positionName = this.txtAddPosition.Text.Trim();

            this.positionService.AddPosition(positionName);
            this.txtAddPosition.Text = null;

            Bind();
        }
    }
}