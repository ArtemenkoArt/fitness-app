using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.Components
{
    public partial class CtrlCoachesOnVisit : UserControl
    {
        #region Fields

        public int CoachId = 0;

        #endregion

        public CtrlCoachesOnVisit(int cId)
        {
            InitializeComponent();

            DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetClientLast(cId);

            if (aDet.Id != 0)
            {

                DBLayer.ClientsAbonements.Details caDet = DBLayer.ClientsAbonements.GetDetails(cId, aDet.Id);

                if ((caDet.Id != 0))
                {
                    if (caDet.CoachId != 0)
                    {
                        DBLayer.Coaches.Details coDet = DBLayer.Coaches.GetDetails(caDet.CoachId);

                        if ((coDet.Id != 0))
                        {
                            lblCoach.Text = DBLayer.Coaches.GetDetails(caDet.CoachId).Name;
                        }
                    }
                    lblTime.Text = caDet.Time;
                    lblWeekdays.Text = WeekDaysView(caDet.Weekdays);
                }
            }

            
            LoadData();
        }

        private string WeekDaysView(string weekdays)
        {
            string view = string.Empty;

            for (int i = 0; i < weekdays.Length; i++)
            {
                int numb = Convert.ToInt32(weekdays[i].ToString());

                view += " " + Lib.ServiceFunctions.NumberToWeekdays(numb);
            }

            return view;
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Coaches.GetList();

            lvCoaches.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.Details det = (DBLayer.Coaches.Details)al[i];

                ListViewItem lvi = new ListViewItem();

                lvi.Text = det.Name;
                lvi.Tag = det.Id;

                lvCoaches.Items.Add(lvi);
            }
        }

        #endregion

        #region Client Select Event

        public delegate void SelectCoachHandler(object sender, CoachSelectEventArgs args);

        public event SelectCoachHandler SelectCoachMsg;

        protected virtual void OnSelectCoach(CoachSelectEventArgs e)
        {
            if (SelectCoachMsg != null)
            {
                SelectCoachMsg(this, e);
            }
        }

        public void SimulateSelectCoach()
        {
            CoachSelectEventArgs e = new CoachSelectEventArgs(this.CoachId);

            OnSelectCoach(e);
        }

        #endregion

        private void lvCoaches_DoubleClick(object sender, EventArgs e)
        {
            if (lvCoaches.SelectedItems.Count > 0)
            {
                if (lvCoaches.SelectedItems[0] != null)
                {
                    this.CoachId = Convert.ToInt32(lvCoaches.SelectedItems[0].Tag);

                    //MessageBox.Show(this.CoachId.ToString());

                    SimulateSelectCoach();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.CoachId = 0;

            //MessageBox.Show(this.CoachId.ToString());

            SimulateSelectCoach();
        }
    }

    #region CoachSelectEventArgs Class

    public class CoachSelectEventArgs : EventArgs
    {
        #region Constructor

        public CoachSelectEventArgs(int id)
        {
            this.Id = id;            
        }

        #endregion

        #region Fields

        public readonly int Id;        

        #endregion
    }

    #endregion
}
