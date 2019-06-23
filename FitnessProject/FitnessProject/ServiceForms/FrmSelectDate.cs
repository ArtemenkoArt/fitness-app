using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.ServiceForms
{
    public partial class FrmSelectDate : Form
    {
        public FrmSelectDate(int month, int year)
        {
            InitializeComponent();

            cbMonth.SelectedIndex = month - 1;

            for (int i = 0; i < cbYear.Items.Count; i++)
            {
                if (Convert.ToInt32(cbYear.Items[i]) == year)
                {
                    cbYear.SelectedIndex = i;
                    break;
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ChooseRangeEventArgs Class

        public class ChooseRangeEventArgs : EventArgs
        {
            #region Constructor

            public ChooseRangeEventArgs(int year, int month)
            {
                this.Year = year;
                this.Month = month;
            }

            #endregion

            #region Fields

            public readonly int Month = 0;
            public readonly int Year = 0;

            #endregion
        }

        #endregion

        #region Choose Range Event

        public delegate void ChooseRangeEventHandler(object sender, ChooseRangeEventArgs args);

        public event ChooseRangeEventHandler SelectDateMsg;

        protected virtual void OnChooseRange(ChooseRangeEventArgs e)
        {
            if (SelectDateMsg != null)
            {
                SelectDateMsg(this, e);
            }
        }

        public void SimulateSelectRange()
        {
            ChooseRangeEventArgs e = new ChooseRangeEventArgs(Convert.ToInt32(cbYear.SelectedItem), cbMonth.SelectedIndex + 1);

            OnChooseRange(e);

            this.Close();
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            SimulateSelectRange();
        }
    }
}
