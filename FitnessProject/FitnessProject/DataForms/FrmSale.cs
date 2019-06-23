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
    public partial class FrmSale : Form
    {
        #region Fields

        public DBLayer.Products.Details Product = new FitnessProject.DBLayer.Products.Details();

        #endregion

        public FrmSale()
        {
            InitializeComponent();

            LoadGroups();
        }

        #region LoadGroups

        private void LoadGroups()
        {
            ArrayList al = DBLayer.ProductGroup.GetList();

            cbProductGroup.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.ProductGroup.Details det = (DBLayer.ProductGroup.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbProductGroup.Items.Add(li);
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbProductGroup.SelectedItem;

            if (cbProduct.Items.Count > 0)
                cbProduct.Items.Clear();

            ArrayList al = DBLayer.Products.GetList(li.ID);

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.Products_WideDetails det = (DBLayer.Products.Products_WideDetails)al[i];

                Lib.ServiceFunctions.ListItem liP = new FitnessProject.Lib.ServiceFunctions.ListItem();

                liP.ID = det.Id;
                liP.Name = det.Name;

                cbProduct.Items.Add(liP);
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDimension.Text = "";

            Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbProduct.SelectedItem;

            DBLayer.Products.Details det = DBLayer.Products.GetDetails(li.ID);

            this.Product = det;

            DBLayer.Dimensions.Details detD = DBLayer.Dimensions.GetDetails(det.DimensionId);

            double quantity = 0;

            if (tbQuantity.Text.Trim() != "")
                quantity = Convert.ToDouble(tbQuantity.Text);

            double cost = (det.Price * quantity);

            lblCost.Text = cost.ToString();

            lblDimension.Text = detD.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBLayer.Sales.Details det = new FitnessProject.DBLayer.Sales.Details();

            det.Date = DateTime.Now.Date;
            det.ProductId = this.Product.Id;
            det.Quantity = Convert.ToInt32(tbQuantity.Text);
            det.Time = DateTime.Now.ToShortTimeString();
            
            DBLayer.Users.Details detU = (DBLayer.Users.Details) AppDomain.CurrentDomain.GetData("User");

            det.UserId = detU.Id;

            DBLayer.Sales.Insert(det);

            this.Close();
        }

        private void tbQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double quantity = 0;

                if (tbQuantity.Text.Trim() != "")
                    quantity = Convert.ToDouble(tbQuantity.Text);

                double cost = (Product.Price * quantity);

                lblCost.Text = cost.ToString();
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quantity = 0;

                if (tbQuantity.Text.Trim() != "")
                    quantity = Convert.ToDouble(tbQuantity.Text);

                double cost = (Product.Price * quantity);

                lblCost.Text = cost.ToString();
            }
            catch { }
        }
    }
}
