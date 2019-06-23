using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FitnessProject.Components
{
    public partial class CtrlInfo : UserControl
    {
        #region Fields

        public DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();
        public int Type = 0;
        public DateTime Date = new DateTime();
        public int Number = 0;
        public bool WithoutKey = false;
        public int CoachId = 0;

        #endregion

        #region LoadCoaches

        public void LoadCoaches()
        {
            Lib.ServiceFunctions.ListItem li0 = new FitnessProject.Lib.ServiceFunctions.ListItem();

            li0.ID = 0;
            li0.Name = "Не указан";

            cbCoaches.Items.Add(li0);

            ArrayList al = DBLayer.Coaches.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.Details det = (DBLayer.Coaches.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbCoaches.Items.Add(li);
            }
        }

        #endregion

        public CtrlInfo(DBLayer.Clients.Details det, DateTime date, int number, int type, bool key, int coachId)
        {
            InitializeComponent();

            this.Details = det;
            this.Date = date;
            this.Type = type;
            this.Number = number;
            this.WithoutKey = key;
            this.CoachId = coachId;


            LoadCoaches();

            string text = "";

            switch (type)
            {
                case 1:
                    text = "Женский";
                    break;
                case 2:
                    text = "Мужской";
                    break;
                case 3:
                    text = "Женский";
                    break;
                case 4:
                    text = "Мужской";
                    break;
            }

            lblClient.Text = det.FIO;

            byte[] result = DBLayer.Clients.DownloadPhoto(det.Id);
            try
            {
                MemoryStream ms = new MemoryStream(result, 0, result.Length);
                Image im = Image.FromStream(ms);
                pbPhoto.Image = im;
            }
            catch (Exception ee)
            {
                pbPhoto.Image = null;
            }

            DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetClientLast(det.Id);

            lblAbonement.Text = aDet.Name;
            lblTime.Text = aDet.Time;
            lblWeekdays.Text = aDet.Weekdays;
            try
            {
                lblCoach.Text = DBLayer.Coaches.GetDetails(aDet.CoachId).Name;
            }
            catch 
            {
                lblCoach.Text = "Не указан";
            }

            DBLayer.ClientsAbonements.Details caDet = DBLayer.ClientsAbonements.GetDetails(det.Id, aDet.Id);

            CADetails = caDet;

            if (caDet.VisitsCount > 0)
            {
                lblVisitCount.Text = caDet.VisitsCount.ToString();
            }

            lblDate.Text = date.ToString("dd-MMM-yyyy hh mm");
            lblNumber.Text = number.ToString() + " " + text;
        }

        DBLayer.ClientsAbonements.Details CADetails = new FitnessProject.DBLayer.ClientsAbonements.Details();

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
            DBLayer.Visits.Visits_Details det = new FitnessProject.DBLayer.Visits.Visits_Details();

            /*MessageBox.Show(this.Type.ToString());
            MessageBox.Show(this.Details.Sex.ToString());
            MessageBox.Show(this.Number.ToString());*/

            //MessageBox.Show(this.Type.ToString());

            if (this.Details.Sex == 1)
            {
                this.Type = 1;
            }
            
            det.BoxId = DBLayer.Boxes.GetId(this.Type, this.Details.Sex, this.Number);
            det.ClientId = this.Details.Id;
            det.Date = DateTime.Now;
            det.Time = DateTime.Now.ToShortTimeString();
            det.Type = 0;
            det.TimeOff = "";
            det.WithoutKey = this.WithoutKey;
            det.CoachId = this.CoachId;

            if (((Lib.ServiceFunctions.ListItem)cbCoaches.SelectedItem).ID != 0)
            {
                det.IsSubstitution = true;

                det.CoachId = ((Lib.ServiceFunctions.ListItem)cbCoaches.SelectedItem).ID;
            }

            DBLayer.Visits.Insert(det);

            CADetails.VisitsCount--;

            DBLayer.ClientsAbonements.Update(CADetails);

            SimulateFinish();
        }

        private void cbSubstitution_CheckedChanged(object sender, EventArgs e)
        {
            //cbCoaches.Enabled = cbSubstitution.Checked;
        }
    }

    #region FinishEventArgs Class

    public class FinishEventArgs : EventArgs
    {
        #region Constructor

        public FinishEventArgs()
        {
            
        }

        #endregion      
    }

    #endregion
}
