using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.Components
{
    public partial class CtrlBoxType : UserControl
    {
        public CtrlBoxType(DBLayer.Clients.Details det)
        {
            InitializeComponent();

            int id = det.Sex;

            DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetClientLast(det.Id);

            lblAbonement.Text = aDet.Name;
            lblFIO.Text = det.FIO;

            
                    DBLayer.ClientsAbonements.Details caDet = DBLayer.ClientsAbonements.GetDetails(det.Id, aDet.Id);

            if (caDet.CoachId != 0)
            {
                lblCoach.Text = DBLayer.Coaches.GetDetails(caDet.CoachId).Name;
            }

            lblTime.Text = caDet.Time;
            lblWeekdays.Text = caDet.Weekdays;

            try
            {
                lblFinishDate.Text = DBLayer.ClientsAbonements.GetFinishDate(det.Id, aDet.Id).ToString("dd-MMM-yyyy");
            }
            catch
            {
            }

            int doubleBox = DBLayer.Boxes.GetList(1, id);

            int singleBox = DBLayer.Boxes.GetList(2, id);

            if (id == 0)
            {
                int val = 0;

                val = singleBox;

                singleBox = doubleBox;
                doubleBox = val;

            }

            lblSingle.Text = (singleBox - DBLayer.Boxes.GetReserved(1, id).Count).ToString();

            lblDouble.Text = (doubleBox - DBLayer.Boxes.GetReserved(2, id).Count).ToString();
        }

        #region Type Select Event

        public delegate void SelectTypeHandler(object sender, TypeSelectEventArgs args);

        public event SelectTypeHandler SelectTypeMsg;

        protected virtual void OnSelectType(TypeSelectEventArgs e)
        {
            if (SelectTypeMsg != null)
            {
                SelectTypeMsg(this, e);
            }
        }

        public void SimulateSelectType()
        {
            int type = 0;

            if (rbSingle.Checked)
                type = 1;
            else
                type = 0;

            TypeSelectEventArgs e = new TypeSelectEventArgs(type);

            OnSelectType(e);
        }

        #endregion

        private void btnType_Click(object sender, EventArgs e)
        {
            SimulateSelectType();
        }
    }

    #region TypeSelectEventArgs Class

    public class TypeSelectEventArgs : EventArgs
    {
        #region Constructor

        public TypeSelectEventArgs(int type)
        {
            this.Type = type;
        }

        #endregion

        #region Fields

        public readonly int Type;

        #endregion
    }

    #endregion
}
