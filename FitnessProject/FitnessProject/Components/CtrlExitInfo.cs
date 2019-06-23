using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.Components
{
    public partial class CtrlExitInfo : UserControl
    {
        #region Fields

        public DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();
        public int VisitId = 0;
        
        #endregion

        public CtrlExitInfo(DBLayer.Clients.Details det)
        {
            InitializeComponent();

            this.Details = det;
           
            lblClient.Text = det.FIO;

            int id = DBLayer.Visits.GetLastVisit(det.Id);

            DBLayer.Visits.Visits_Details vDet = DBLayer.Visits.GetDetails(id);

            lblBox.Text = DBLayer.Boxes.GetNumber(vDet.BoxId).ToString();

            this.VisitId = id;

            if (id != 0)
            {
                DBLayer.Visits.Visits_Details detV = DBLayer.Visits.GetDetails(id);

                lblDate.Text = detV.Time;
            }
                        
        }

        #region Finish Event

        public delegate void FinishHandler(object sender, FinishEventArgs args);

        public event FinishHandler FinishMsg;

        protected virtual void OnFinish(FinishEventArgs e)
        {
            if (FinishMsg != null)
            {
                FinishMsg(this, e);
            }
        }

        public void SimulateFinish()
        {
            FinishEventArgs e = new FinishEventArgs();

            OnFinish(e);
        }

        #endregion

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DBLayer.Visits.SetTimeOff(this.VisitId, DateTime.Now.ToShortTimeString());

            SimulateFinish();
        }
    }

    
}
