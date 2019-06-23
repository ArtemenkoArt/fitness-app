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
    public partial class FrmEditArrivalLine : Form
    {
        #region Fields

        public int Id = 0;

        #endregion

        public FrmEditArrivalLine(int id)
        {
            InitializeComponent();

            this.Id = id;

            LoadGroups(0);
        }

        #region LoadGroups

        private void LoadGroups(int id)
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

            DBLayer.Dimensions.Details detD = DBLayer.Dimensions.GetDetails(det.DimensionId);

            lblDimension.Text = detD.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBLayer.ArrivalDetails.Details det = new FitnessProject.DBLayer.ArrivalDetails.Details();

            det.ArrivalId = this.Id;
            det.Price = Convert.ToDouble(tbPrice.Text);
            det.ProductId = ((Lib.ServiceFunctions.ListItem)cbProduct.SelectedItem).ID;
            det.Quantity = Convert.ToDouble(tbQuantity.Text);

            DBLayer.ArrivalDetails.Insert(det);

            this.Close();
        }
    }
}
