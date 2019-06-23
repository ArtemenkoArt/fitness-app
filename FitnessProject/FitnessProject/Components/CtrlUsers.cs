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
    public partial class CtrlUsers : UserControl
    {
        public CtrlUsers()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Users.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Code");
            dt.Columns.Add("JobTitle");
            dt.Columns.Add("FIO");
            dt.Columns.Add("Login");
            dt.Columns.Add("Administrator");     

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Users.Details det = (DBLayer.Users.Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Code"] = det.Barcode;

                dr["JobTitle"] = det.JobTitle;
                dr["FIO"] = det.FIO;

                dr["Login"] = det.Login;

                if (det.IsAdmin)
                    dr["Administrator"] = "Администратор";
                else
                    dr["Administrator"] = "Пользователь";

            }

            grGoods.DataSource = dt;
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditUser frm = new FitnessProject.DataForms.FrmEditUser();
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

            DataForms.FrmEditUser frm = new FitnessProject.DataForms.FrmEditUser(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Users.Delete(ind);

                LoadData();
            }
        }
    }
}
