using AppraisalSystem.Web.PositionService;
using System;
using System.Collections.Generic;

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
            IEnumerable<Position> positions = positionService.GetAllPositions();
        }
    }
}