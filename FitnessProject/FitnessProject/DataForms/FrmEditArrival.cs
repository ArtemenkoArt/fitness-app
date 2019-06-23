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
    public partial class FrmEditArrival : Form
    {
        #region Fields

        public int Id = 0;
        public DBLayer.ArrivalDetails.Details Details = new FitnessProject.DBLayer.ArrivalDetails.Details();

        #endregion

        public FrmEditArrival()
        {
            InitializeComponent();

            LoadSuppliers(0);
            LoadProducts(0);
        }

        public FrmEditArrival(int id)
        {
            InitializeComponent();
                        
            this.Id = id;

            this.Details = DBLayer.ArrivalDetails.GetDetails(id);

            LoadSuppliers(this.Details.SupplierId);
            LoadProducts(this.Details.ProductId);

            tbDate.Text = this.Details.Date.ToString("dd-MMM-yyyy");
            tbPrice.Text = this.Details.Price.ToString();
            tbQuantity.Text = this.Details.Quantity.ToString();
                                    
            
        }

        #region LoadSuppliers

        private void LoadSuppliers(int id)
        {
            ArrayList al = DBLayer.Suppliers.GetList();

            cbSuppliers.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Suppliers.Details det = (DBLayer.Suppliers.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbSuppliers.Items.Add(li);
            }

            if (cbSuppliers.Items.Count > 0)
            {
                if (id == 0)
                    cbSuppliers.SelectedIndex = 0;
                else
                {
                    for (int i = 0; i < cbSuppliers.Items.Count; i++)
                    {
                        Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbSuppliers.Items[i];

                        if (li.ID == id)
                        {
                            cbSuppliers.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        #endregion

        #region LoadProducts

        private void LoadProducts(int id)
        {
            ArrayList al = DBLayer.Products.GetList();

            cbProduct.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.Products_WideDetails det = (DBLayer.Products.Products_WideDetails)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbProduct.Items.Add(li);
            }

            if (cbProduct.Items.Count > 0)
            {
                if (id == 0)
                    cbProduct.SelectedIndex = 0;
                else
                {
                    for (int i = 0; i < cbProduct.Items.Count; i++)
                    {
                        Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbProduct.Items[i];

                        if (li.ID == id)
                        {
                            cbProduct.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        #endregion              

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSuppliers_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm = new FitnessProject.ServiceForms.FrmCalendar();
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
        }

        private void tbDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbDate.Text = "";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.SupplierId = ((Lib.ServiceFunctions.ListItem)cbSuppliers.SelectedItem).ID;
            this.Details.ProductId = ((Lib.ServiceFunctions.ListItem)cbProduct.SelectedItem).ID;
            this.Details.Date = Convert.ToDateTime(tbDate.Text);
            this.Details.Price = Convert.ToDouble(tbPrice.Text);
            this.Details.Quantity = Convert.ToDouble(tbQuantity.Text);

            if (this.Id == 0)
            {
                this.Details.Id = DBLayer.ArrivalDetails.Insert(this.Details);

                DBLayer.Charges.Details det = new FitnessProject.DBLayer.Charges.Details();

                det.AdminstratorId = ((DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User")).Id;
                det.Date = DateTime.Now.Date;
                det.GroupId = 4;
                det.Name = "Закупка " + ((Lib.ServiceFunctions.ListItem)cbProduct.SelectedItem).Name;
                det.Summ = this.Details.Price * this.Details.Quantity;

                int id = DBLayer.Charges.Insert(det);

                this.Details.ChargeId = id;

                DBLayer.ArrivalDetails.Update(this.Details);
            }
            else
            {
                DBLayer.ArrivalDetails.Update(this.Details);

                if (this.Details.ChargeId != 0)
                {
                    DBLayer.Charges.Details chDet = DBLayer.Charges.GetDetails(this.Details.ChargeId);

                    chDet.Date = this.Details.Date;
                    chDet.Summ = this.Details.Price * this.Details.Quantity;

                    DBLayer.Charges.Update(chDet);
                }
            }

            this.Close();
        }
                

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                //advBandedGridView1.ExportToExcel(sfdExcel.FileName);
            }
        }        
    }
}
