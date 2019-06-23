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
    public partial class CtrlSuppliers : UserControl
    {
        public CtrlSuppliers()
        {
            InitializeComponent();

            DBLayer.Users.Details det = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            if (det.IsAdmin)
                tbtnRemove.Visible = true;
            else
                tbtnRemove.Visible = false;

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Suppliers.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Director");
            dt.Columns.Add("Fax");
            dt.Columns.Add("Phone");

            dt.Columns.Add("Type", typeof(int));

            dt.Columns.Add("TypeName");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Suppliers.Details det = (DBLayer.Suppliers.Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Name"] = det.Name;

                dr["Director"] = det.Director;
                dr["Phone"] = det.Phone;

                dr["Fax"] = det.Fax;

                switch (det.Type)
                {
                    case 0:
                        dr["TypeName"] = "Постоянный";
                        break;
                    case 1:
                        dr["TypeName"] = "Единоразовый";
                        break;
                    case 2:
                        dr["TypeName"] = "Ситуативный";
                        break;
                }

            }

            grSources.DataSource = dt;
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditSupplier frm = new FitnessProject.DataForms.FrmEditSupplier();
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

            DataForms.FrmEditSupplier frm = new FitnessProject.DataForms.FrmEditSupplier(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить поставщика?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Suppliers.Delete(ind);

                LoadData();
            }
        }
    }
}
