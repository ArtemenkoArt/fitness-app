using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.DataForms
{
    public partial class FrmEditClientAbonement : Form
    {
        #region Fields

        public int Id = 0;
        public DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();

        public DBLayer.ClientsAbonements.Details CADetails = new FitnessProject.DBLayer.ClientsAbonements.Details();

        public int AbonementId = 0;
        private string Name = "";

        #endregion

        public FrmEditClientAbonement()
        {
            InitializeComponent();

            LoadCoaches(1);
        }

        public FrmEditClientAbonement(DBLayer.Clients.Details det)
        {
            InitializeComponent();

            this.Details = det;

            LoadCoaches(1);
        }

        public FrmEditClientAbonement(int id)
        {
            InitializeComponent();

            this.Id = id;

            DBLayer.ClientsAbonements.Details det = DBLayer.ClientsAbonements.GetDetails(id);

            this.CADetails = det;

            var abonement = DBLayer.Abonements.GetDetails(det.AbonementId);

            lblAbonement.Text = abonement.Name;

            LoadCoaches(1);

            tbTime.Text = det.Time;
            tbWeekdays.Text = det.Weekdays;

            tbFinishDate.Text = det.DateFinish.ToString("dd-MMM-yyyy");
            tbStartDate.Text = det.DateStart.ToString("dd-MMM-yyyy");
        }

        private void btnStartDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm = new FitnessProject.ServiceForms.FrmCalendar();
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbStartDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");


            DBLayer.Abonements.Details abon = DBLayer.Abonements.GetDetails(this.AbonementId);

            tbFinishDate.Text = args.SelectedDate.AddMonths(Convert.ToInt32(abon.Length)).AddDays(-1).ToString("dd-MMM-yyyy");
        }

        private void btnFinishDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm2 = new FitnessProject.ServiceForms.FrmCalendar();
            frm2.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm2_SelectDateMsg);
            frm2.ShowDialog();
        }

        void frm2_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbFinishDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
        }

        #region LoadCoaches

        private void LoadCoaches(int id)
        {
            cbCoach.Items.Clear();

            ArrayList al = DBLayer.Coaches.GetList(id);

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.Details det = (DBLayer.Coaches.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbCoach.Items.Add(li);
            }

        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Abonement Select Event

        public delegate void SelectAbonementHandler(object sender, AbonementSelectEventArgs args);

        public event SelectAbonementHandler SelectAbonementMsg;

        protected virtual void OnSelectAbonement(AbonementSelectEventArgs e)
        {
            if (SelectAbonementMsg != null)
            {
                SelectAbonementMsg(this, e);
            }
        }

        public void SimulateSelectAbonement()
        {
            int coachId = 0;
            string coachName = string.Empty;

            if (cbCoach.SelectedItem != null)
            {
                coachId = ((Lib.ServiceFunctions.ListItem)cbCoach.SelectedItem).ID;
                coachName = DBLayer.Coaches.GetDetails(coachId).Name;
            }

            AbonementSelectEventArgs e = new AbonementSelectEventArgs(this.AbonementId, 
                this.Name, 
                Convert.ToDateTime(tbStartDate.Text), 
                Convert.ToDateTime(tbFinishDate.Text), 
                coachId, 
                tbWeekdays.Text, 
                tbTime.Text, 
                coachName);

            OnSelectAbonement(e);

            this.Close();
        }

        #endregion

        #region AbonementSelectEventArgs Class

        public class AbonementSelectEventArgs : EventArgs
        {
            #region Constructor

            public AbonementSelectEventArgs(int id, string name, DateTime date1, DateTime date2, int coachId, string weekDays, string time, string coachName)
            {
                this.Details.AbonementId = id;
                this.Details.DateStart = date1;
                this.Details.DateFinish = date2;
                this.Details.Name = name;
                if (coachId != 0)
                {
                    this.Details.CoachId = coachId;
                }
                this.Details.Weekdays = weekDays;
                this.Details.Time = time;
                this.Details.CoachName = coachName;
            }

            #endregion

            #region Fields

            public readonly DBLayer.ClientsAbonements.ClientsAbonements_WideDetails Details = new FitnessProject.DBLayer.ClientsAbonements.ClientsAbonements_WideDetails();

            #endregion
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.AbonementId == 0)
            {
                MessageBox.Show(this, "Не указан абонемент!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a = 0;

            if (this.Id == 0)
            {
                if (this.Details.Id == 0)
                    SimulateSelectAbonement();
                else
                {
                    this.CADetails.AbonementId = this.AbonementId;

                    DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetDetails(this.CADetails.AbonementId);

                    this.CADetails.DateStart = Convert.ToDateTime(tbStartDate.Text);
                    this.CADetails.DateFinish = Convert.ToDateTime(tbFinishDate.Text);
                    this.CADetails.ClientId = this.Details.Id;

                    if (cbCoach.SelectedItem != null)
                        this.CADetails.CoachId = ((Lib.ServiceFunctions.ListItem)cbCoach.SelectedItem).ID;

                    this.CADetails.Time = tbTime.Text;
                    this.CADetails.Weekdays = tbWeekdays.Text;

                    if (aDet.LessonsCount != 0)
                    {
                        this.CADetails.VisitsCount = aDet.LessonsCount;
                    }

                    if (aDet.AdditionalVisits != 0)
                    {
                        this.CADetails.AdditionalCount = aDet.AdditionalVisits;
                    }

                    if (aDet.LessonsCount != 0)
                    {
                        this.CADetails.VisitsCount = aDet.LessonsCount;
                    }

                    if (aDet.AdditionalVisits != 0)
                    {
                        this.CADetails.AdditionalCount = aDet.AdditionalVisits;
                    }

                    if (MessageBox.Show(this, "Провести платеж - " + aDet.Cost.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int caId = DBLayer.ClientsAbonements.Insert(this.CADetails);

                        DBLayer.AbonementIncome.Details det = new FitnessProject.DBLayer.AbonementIncome.Details();

                        DBLayer.Users.Details uDet = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

                        det.AbonementId = this.CADetails.AbonementId;
                        det.ClientId = this.CADetails.ClientId;
                        det.Date = DateTime.Now.Date;
                        det.Summ = aDet.Cost;
                        det.UserId = uDet.Id;
                        det.ClientAbonementId = caId;

                        DBLayer.AbonementIncome.Insert(det);
                    }

                    this.Close();
                }
            }
            else
            {
                this.CADetails.AbonementId = this.AbonementId;
                this.CADetails.DateStart = Convert.ToDateTime(tbStartDate.Text);
                this.CADetails.DateFinish = Convert.ToDateTime(tbFinishDate.Text);

                if (cbCoach.SelectedItem != null)
                    this.CADetails.CoachId = ((Lib.ServiceFunctions.ListItem)cbCoach.SelectedItem).ID;

                this.CADetails.Time = tbTime.Text;
                this.CADetails.Weekdays = tbWeekdays.Text;

                DBLayer.ClientsAbonements.Update(this.CADetails);

                this.Close();
            }
        }

        private void cbAbonement_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rbFitness_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAbonements(0);
            //LoadCoaches(1);
        }

        private void rbAero_CheckedChanged(object sender, EventArgs e)
        {
            //LoadAbonements(0);
            //LoadCoaches(0);
        }

        private void btnSelectAbonement_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmSelectAbonement frm = new ServiceForms.FrmSelectAbonement();
            frm.SelectAbonementMsg += frm_SelectAbonementMsg;
            frm.ShowDialog();
        }

        void frm_SelectAbonementMsg(object sender, ServiceForms.FrmSelectAbonement.SelectAbonementEventArgs args)
        {
            this.AbonementId = args.Id;
            this.Name = args.Name;

            lblAbonement.Text = args.Name;

            if (tbStartDate.Text.Trim() != "")
            {
                DBLayer.Abonements.Details abon = DBLayer.Abonements.GetDetails(args.Id);

                if (!abon.IsSingle)
                {
                    tbFinishDate.Text = Convert.ToDateTime(tbStartDate.Text).AddMonths(Convert.ToInt32(abon.Length)).ToString("dd-MMM-yyyy");
                }
                else
                {
                    tbFinishDate.Text = tbStartDate.Text;
                }
            }
        }
    }
}
