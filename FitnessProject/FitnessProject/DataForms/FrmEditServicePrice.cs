using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditServicePrice : Form
    {
        private int Id = 0;
        private DBLayer.ServicePriceDynamic.Details Details = new FitnessProject.DBLayer.ServicePriceDynamic.Details();
        DBLayer.Services.Details ProductDetails = new FitnessProject.DBLayer.Services.Details();

        public FrmEditServicePrice(DBLayer.Services.Details det)
        {
            InitializeComponent();

            this.ProductDetails = det;
        }

        public FrmEditServicePrice(int id)
        {
            InitializeComponent();

            this.Details = DBLayer.ServicePriceDynamic.GetDetails(id);

            this.Id = id;

            dtpFinish.Value = this.Details.DateFinish;
            dtpStart.Value = this.Details.DateStart;
            tbPrice.Text = this.Details.Price.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.DateStart = dtpStart.Value;
            this.Details.DateFinish = dtpFinish.Value;
            this.Details.Price = Convert.ToDouble(tbPrice.Text);

            if (this.Id == 0)
            {
                Details.ServiceId = this.ProductDetails.Id;

                DBLayer.ServicePriceDynamic.Insert(this.Details);
            }
            else
            {
                DBLayer.ServicePriceDynamic.Update(this.Details);
            }

            this.Close();
        }
    }
}
