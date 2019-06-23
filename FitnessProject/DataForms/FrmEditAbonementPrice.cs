using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditAbonementPrice : Form
    {
        private int Id = 0;
        private DBLayer.AbonementPriceDynamic.Details Details = new FitnessProject.DBLayer.AbonementPriceDynamic.Details();
        DBLayer.Abonements.Details ProductDetails = new FitnessProject.DBLayer.Abonements.Details();

        public FrmEditAbonementPrice(DBLayer.Abonements.Details det)
        {
            InitializeComponent();

            this.ProductDetails = det;
        }

        public FrmEditAbonementPrice(int id)
        {
            InitializeComponent();

            this.Details = DBLayer.AbonementPriceDynamic.GetDetails(id);

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
                Details.AbonementId = this.ProductDetails.Id;

                DBLayer.AbonementPriceDynamic.Insert(this.Details);
            }
            else
            {
                DBLayer.AbonementPriceDynamic.Update(this.Details);
            }

            this.Close();
        }
    }
}
