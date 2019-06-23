using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.Components
{
    public partial class CtrlGoods : UserControl
    {
        public CtrlGoods()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Products.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("GroupName");
            dt.Columns.Add("Name");
            dt.Columns.Add("Dimension");
            dt.Columns.Add("Price", typeof(double));

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.Products_WideDetails det = (DBLayer.Products.Products_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["GroupName"] = det.GroupName;

                dr["Name"] = det.Name;
                dr["Dimension"] = det.DimensionName;

                dr["Price"] = det.Price;

            }

            grGoods.DataSource = dt;
            advBandedGridView1.BestFitColumns();

            slblTotal.Text = advBandedGridView1.RowCount.ToString();
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditGood frm = new FitnessProject.DataForms.FrmEditGood();
            frm.ShowDialog();

            LoadData();
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

            DataForms.FrmEditGood frm = new FitnessProject.DataForms.FrmEditGood(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить продукт?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Products.Delete(ind);

                LoadData();
            }
        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            slblTotal.Text = advBandedGridView1.RowCount.ToString();
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
            }
        }
    }
}
