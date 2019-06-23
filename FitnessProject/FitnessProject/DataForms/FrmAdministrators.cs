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
    public partial class FrmAdministrators : Form
    {
        #region Fields

        public int Id = 0;

        #endregion

        public FrmAdministrators()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Administrators.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Administrators.Details det = (DBLayer.Administrators.Details)al[i];

                if (!det.IsTired)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = det.FIO;
                    lvi.Tag = det.Id;

                    lvAdministrators.Items.Add(lvi);
                }
            }
        }

        #endregion

        private void lvAdministrators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdministrators.SelectedItems.Count > 0)
            {
                this.Id = Convert.ToInt32(lvAdministrators.SelectedItems[0].Tag);
            }
        }

        private void lvAdministrators_DoubleClick(object sender, EventArgs e)
        {
            SimulateReason();
        }

        #region Select Event

        public delegate void AdminEventHandler(object sender, AdminEventArgs args);

        public event AdminEventHandler SelectAdminMsg;

        protected virtual void OnSelectAdmin(AdminEventArgs e)
        {
            if (SelectAdminMsg != null)
            {
                SelectAdminMsg(this, e);
            }
        }

        public void SimulateReason()
        {
            AdminEventArgs e = new AdminEventArgs(this.Id);

            OnSelectAdmin(e);

            this.Close();
        }

        #endregion

        #region AdminEventArgs Class

        public class AdminEventArgs : EventArgs
        {
            #region Constructor

            public AdminEventArgs(int id)
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
}
