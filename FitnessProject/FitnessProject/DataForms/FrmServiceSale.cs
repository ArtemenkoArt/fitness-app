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
    public partial class FrmServiceSale : Form
    {
        #region Fields

        public DBLayer.Services.Details Product = new FitnessProject.DBLayer.Services.Details();

        #endregion

        public FrmServiceSale()
        {
            InitializeComponent();

            LoadServices();
        }

        #region LoadServices

        private void LoadServices()
        {
            ArrayList al = DBLayer.Services.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Services.Services_WideDetails det = (DBLayer.Services.Services_WideDetails)al[i];

                Lib.ServiceFunctions.ListItem liP = new FitnessProject.Lib.ServiceFunctions.ListItem();

                liP.ID = det.Id;
                liP.Name = det.Name;

                cbProduct.Items.Add(liP);
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDimension.Text = "";

            Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbProduct.SelectedItem;

            DBLayer.Services.Details det = DBLayer.Services.GetDetails(li.ID);

            this.Product = det;

            double quantity = 0;

            if (tbQuantity.Text.Trim() != "")
                quantity = Convert.ToDouble(tbQuantity.Text);

            double cost = (det.CostPerUnit * quantity);

            lblCost.Text = cost.ToString();


            DBLayer.Dimensions.Details detD = DBLayer.Dimensions.GetDetails(det.DimensionId);

            lblDimension.Text = detD.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBLayer.ServiceSales.Details det = new FitnessProject.DBLayer.ServiceSales.Details();

            det.Date = DateTime.Now.Date;
            det.ServiceId = this.Product.Id;
            det.Quantity = Convert.ToInt32(tbQuantity.Text);
            det.Time = DateTime.Now.ToShortTimeString();
            
            DBLayer.Users.Details detU = (DBLayer.Users.Details) AppDomain.CurrentDomain.GetData("User");

            det.UserId = detU.Id;

            DBLayer.ServiceSales.Insert(det);

            this.Close();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quantity = 0;

                if (tbQuantity.Text.Trim() != "")
                    quantity = Convert.ToDouble(tbQuantity.Text);

                double cost = (Product.CostPerUnit * quantity);

                lblCost.Text = cost.ToString();
            }
            catch { }
        }

        private void tbQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double quantity = 0;

                if (tbQuantity.Text.Trim() != "")
                    quantity = Convert.ToDouble(tbQuantity.Text);

                double cost = (Product.CostPerUnit * quantity);

                lblCost.Text = cost.ToString();
            }
        }
    }
}
