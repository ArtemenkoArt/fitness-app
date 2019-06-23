using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditAdministrator : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Administrators.Details Details = new FitnessProject.DBLayer.Administrators.Details();

        #endregion

        public FrmEditAdministrator()
        {
            InitializeComponent();
        }

        public FrmEditAdministrator(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Administrators.GetDetails(id);

            tbName.Text = this.Details.FIO;
            cbTired.Checked = this.Details.IsTired;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.FIO = tbName.Text;
            this.Details.IsTired = cbTired.Checked;

            if (this.Id == 0)
            {
                DBLayer.Administrators.Insert(this.Details);

                this.Close();
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.Administrators.Update(this.Details);

                this.Close();
            }
        }
    }
}
