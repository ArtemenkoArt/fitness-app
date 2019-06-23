using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.ServiceForms
{
    public partial class FrmDeleteReason : Form
    {
        public FrmDeleteReason()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Select Event

        public delegate void ReasonEventHandler(object sender, ReasonEventArgs args);

        public event ReasonEventHandler SelectReasonMsg;

        protected virtual void OnSelectReason(ReasonEventArgs e)
        {
            if (SelectReasonMsg != null)
            {
                SelectReasonMsg(this, e);
            }
        }

        public void SimulateReason()
        {
            ReasonEventArgs e = new ReasonEventArgs(tbReason.Text);

            OnSelectReason(e);

            this.Close();
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            SimulateReason();
        }
    }

    #region DateSelectEventArgs Class

    public class ReasonEventArgs : EventArgs
    {
        #region Constructor

        public ReasonEventArgs(string text)
        {
            this.Reason = text;
        }

        #endregion

        #region Fields

        public readonly string Reason;

        #endregion
    }

    #endregion
}
