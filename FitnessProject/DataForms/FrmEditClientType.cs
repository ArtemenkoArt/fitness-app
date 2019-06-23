using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditClientType : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.ClientTypes.Details Details = new FitnessProject.DBLayer.ClientTypes.Details();

        #endregion

        public FrmEditClientType()
        {
            InitializeComponent();
        }

        public FrmEditClientType(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.ClientTypes.GetDetails(id);

            tbName.Text = this.Details.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Name = tbName.Text;

            if (this.Id == 0)
            {
                DBLayer.ClientTypes.Insert(this.Details);

                this.Close();
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.ClientTypes.Update(this.Details);

                this.Close();
            }
        }
    }
}
