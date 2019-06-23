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
    public partial class CtrlServices : UserControl
    {
        public CtrlServices()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Services.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Dimension");
            dt.Columns.Add("CostPerUnit", typeof(double));
            dt.Columns.Add("Type");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Services.Services_WideDetails det = (DBLayer.Services.Services_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;

                dr["Name"] = det.Name;
                dr["Dimension"] = det.DimensionName;

                dr["CostPerUnit"] = det.CostPerUnit;

                string name = string.Empty;

                switch (det.Type)
                {
                    case 0:
                        name = "Солярий";
                        break;
                    case 1:
                        name = "Массаж";
                        break;
                    case 2:
                        name = "Сауна";
                        break;
                    case 3:
                        name = "Косметология";
                        break;
                    case 4:
                        name = "Аренда";
                        break;
                }

                dr["Type"] = name;
            }

            grGoods.DataSource = dt;
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditService frm = new FitnessProject.DataForms.FrmEditService();
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

            DataForms.FrmEditService frm = new FitnessProject.DataForms.FrmEditService(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить услугу?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Services.Delete(ind);

                LoadData();
            }
        }
    }
}
