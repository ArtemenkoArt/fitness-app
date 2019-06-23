using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditAdvertisingSource : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.AdvertisingSource.Details Details = new FitnessProject.DBLayer.AdvertisingSource.Details();

        #endregion

        #region Constructor

        public FrmEditAdvertisingSource()
        {
            InitializeComponent();
        }

        public FrmEditAdvertisingSource(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.AdvertisingSource.GetDetails(id);

            tbName.Text = this.Details.Name;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Name = tbName.Text;

            if (this.Id == 0)
            {
                DBLayer.AdvertisingSource.Insert(this.Details);

                this.Close();
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.AdvertisingSource.Update(this.Details);

                this.Close();
            }
        }
    }
}
