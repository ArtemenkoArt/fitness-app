using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditPrice : Form
    {
        private int Id = 0;
        private DBLayer.ProductPriceDynamic.Details Details = new FitnessProject.DBLayer.ProductPriceDynamic.Details();
        DBLayer.Products.Details ProductDetails = new FitnessProject.DBLayer.Products.Details();

        public FrmEditPrice(DBLayer.Products.Details det)
        {
            InitializeComponent();

            this.ProductDetails = det;
        }

        public FrmEditPrice(int id)
        {
            InitializeComponent();

            this.Details = DBLayer.ProductPriceDynamic.GetDetails(id);

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
                Details.ProductId = this.ProductDetails.Id;

                DBLayer.ProductPriceDynamic.Insert(this.Details);
            }
            else
            {
                DBLayer.ProductPriceDynamic.Update(this.Details);
            }

            this.Close();
        }
    }
}
