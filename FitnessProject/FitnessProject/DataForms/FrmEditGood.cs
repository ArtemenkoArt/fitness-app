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
    public partial class FrmEditGood : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Products.Details Details = new FitnessProject.DBLayer.Products.Details();

        #endregion

        #region LoadDimensions

        private void LoadDimensions(int id)
        {
            ArrayList al = DBLayer.Dimensions.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Dimensions.Details det = (DBLayer.Dimensions.Details) al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbDimension.Items.Add(li);
            }

            for (int i = 0; i < cbDimension.Items.Count; i++)
            {
                Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbDimension.Items[i];

                if (li.ID == id)
                {
                    cbDimension.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region LoadGroups

        private void LoadGroups(int id)
        {
            ArrayList al = DBLayer.ProductGroup.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.ProductGroup.Details det = (DBLayer.ProductGroup.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbGroup.Items.Add(li);
            }

            if (cbGroup.Items.Count > 0)
            {
                for (int i = 0; i < cbGroup.Items.Count; i++)
                {
                    Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbGroup.Items[i];

                    if (li.ID == id)
                    {
                        cbGroup.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        #endregion

        #region LoadPrices

        private void LoadPrices(int id)
        {
            ArrayList al = DBLayer.ProductPriceDynamic.GetList(this.Id);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("DateStart", typeof(DateTime));
            dt.Columns.Add("DateFinish", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.ProductPriceDynamic.Details det = (DBLayer.ProductPriceDynamic.Details) al[i];

                dr["Id"] = det.Id;
                dr["Price"] = det.Price;

                dr["DateStart"] = det.DateStart;
                dr["DateFinish"] = det.DateFinish;
            }

            grPrices.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        public FrmEditGood()
        {
            InitializeComponent();

            LoadDimensions(0);
            LoadGroups(0);
        }

        public FrmEditGood(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Products.GetDetails(id);

            LoadDimensions(Details.DimensionId);
            LoadGroups(Details.GroupId);

            tbCode.Text = Details.Barcode;
            tbName.Text = Details.Name;
            tbCurrentPrice.Text = Details.Price.ToString();

            LoadPrices(this.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditPrice frm = new FrmEditPrice(DBLayer.Products.GetDetails(this.Id));
            frm.ShowDialog();

            LoadPrices(this.Id);
        }

        private void tbtnEdit_Click(object sender, EventArgs e)
        {
            int[] i;
            int SelRow = -1;
            i = advBandedGridView1.GetSelectedRows();
            SelRow = i[0];

            int ind = 0;

            try
            {
                ind = Convert.ToInt32(advBandedGridView1.GetRowCellValue(SelRow, "Id"));
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            DataForms.FrmEditPrice frm = new FrmEditPrice(ind);
            frm.ShowDialog();

            LoadPrices(this.Id);
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить прайс?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] i;
                int SelRow = -1;
                i = advBandedGridView1.GetSelectedRows();
                SelRow = i[0];

                int ind = 0;

                try
                {
                    ind = Convert.ToInt32(advBandedGridView1.GetRowCellValue(SelRow, "Id"));
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DBLayer.ProductPriceDynamic.Delete(ind);

                LoadPrices(this.Id);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Price = Convert.ToDouble(tbCurrentPrice.Text);
            this.Details.Name = tbName.Text;
            this.Details.Barcode = tbCode.Text;
            this.Details.DimensionId = ((Lib.ServiceFunctions.ListItem)cbDimension.SelectedItem).ID;
            this.Details.GroupId = ((Lib.ServiceFunctions.ListItem)cbGroup.SelectedItem).ID;

            if (this.Id == 0)
            {
                DBLayer.Products.Insert(this.Details);
            }
            else
            {
                DBLayer.Products.Update(this.Details);
            }

            this.Close();
        }
    }
}
