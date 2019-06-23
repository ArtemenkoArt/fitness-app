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
    public partial class CtrlAdvertisingSource : UserControl
    {
        public CtrlAdvertisingSource()
        {
            InitializeComponent();

            LoadData();

            DBLayer.Users.Details det = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            if (det.IsAdmin)
                tbtnRemove.Visible = true;
            else
                tbtnRemove.Visible = false;
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.AdvertisingSource.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AdvertisingSource.Details det = (DBLayer.AdvertisingSource.Details) al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Name"] = det.Name;
            }

            grSources.DataSource = dt;
        }

        #endregion

        #region tbtnAdd_Click

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditAdvertisingSource frm = new FitnessProject.DataForms.FrmEditAdvertisingSource();
            frm.ShowDialog();

            LoadData();
        }

        #endregion

        #region tbtnEdit_Click

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

            DataForms.FrmEditAdvertisingSource frm = new FitnessProject.DataForms.FrmEditAdvertisingSource(ind);
            frm.ShowDialog();

            LoadData();
        }

        #endregion

        #region tbtnRemove_Click

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить источник привлечения?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.AdvertisingSource.Delete(ind);

                LoadData();
            }
        }

        #endregion
    }
}
