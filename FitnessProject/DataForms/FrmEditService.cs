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
    public partial class FrmEditService : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Services.Details Details = new FitnessProject.DBLayer.Services.Details();

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
               
        public FrmEditService()
        {
            InitializeComponent();

            LoadDimensions(0);

            tbcProducts.TabPages.RemoveAt(1);
        }

        public FrmEditService(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Services.GetDetails(id);

            LoadDimensions(Details.DimensionId);

            tbName.Text = Details.Name;
            tbCurrentPrice.Text = Details.CostPerUnit.ToString();

            cbType.SelectedIndex = Details.Type;

            LoadPrices();
        }

        #region LoadPrices

        private void LoadPrices()
        {
            ArrayList al = DBLayer.ServicePriceDynamic.GetList(this.Id);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("DateStart", typeof(DateTime));
            dt.Columns.Add("DateFinish", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.ServicePriceDynamic.Details det = (DBLayer.ServicePriceDynamic.Details)al[i];

                dr["Id"] = det.Id;
                dr["Price"] = det.Price;

                dr["DateStart"] = det.DateStart;
                dr["DateFinish"] = det.DateFinish;
            }

            grPrices.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditServicePrice frm = new FrmEditServicePrice(DBLayer.Services.GetDetails(this.Id));
            frm.ShowDialog();

            LoadPrices();
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


            DataForms.FrmEditServicePrice frm = new FrmEditServicePrice(ind);
            frm.ShowDialog();

            LoadPrices();
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

                DBLayer.ServicePriceDynamic.Delete(ind);

                LoadPrices();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.CostPerUnit = Convert.ToDouble(tbCurrentPrice.Text);
            this.Details.Name = tbName.Text;
            this.Details.DimensionId = ((Lib.ServiceFunctions.ListItem)cbDimension.SelectedItem).ID;
            this.Details.Type = cbType.SelectedIndex;

            if (this.Id == 0)
            {
                int id = DBLayer.Services.Insert(this.Details);

                DBLayer.ServicePriceDynamic.Details sDet = new FitnessProject.DBLayer.ServicePriceDynamic.Details();

                sDet.DateFinish = DateTime.Now.AddYears(1);
                sDet.DateStart = DateTime.Now;
                sDet.ServiceId = id;
                sDet.Price = Convert.ToDouble(tbCurrentPrice.Text);

                DBLayer.ServicePriceDynamic.Insert(sDet);
            }
            else
            {
                DBLayer.Services.Update(this.Details);
            }

            this.Close();
        }
    }
}
