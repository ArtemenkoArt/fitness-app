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
    public partial class CtrlCoaches : UserControl
    {
        public CtrlCoaches()
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
            ArrayList al = DBLayer.Coaches.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Type");
            dt.Columns.Add("HireDate", typeof(DateTime));
            dt.Columns.Add("Birthdate", typeof(DateTime));
            dt.Columns.Add("FireDate", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.Details det = (DBLayer.Coaches.Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Name"] = det.Name;
                dr["Phone"] = det.Phone;

                if (det.Sex == 0)
                {
                    dr["Sex"] = "Женщина";
                }
                else if (det.Sex == 1)
                {
                    dr["Sex"] = "Мужчина";
                }

                if (det.Type == 0)
                {
                    dr["Type"] = "Аэробика";
                }
                else if (det.Type == 1)
                {
                    dr["Type"] = "Тренажерный зал";
                }

                if (det.HireDate != DateTime.MinValue)
                {
                    dr["HireDate"] = det.HireDate;
                }

                if (det.FireDate != DateTime.MinValue)
                {
                    dr["FireDate"] = det.FireDate;
                }

                if (det.BirthDate != DateTime.MinValue)
                {
                    dr["Birthdate"] = det.BirthDate;
                }
            }

            grSources.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditCoach frm = new FitnessProject.DataForms.FrmEditCoach();
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

            DataForms.FrmEditCoach frm = new FitnessProject.DataForms.FrmEditCoach(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить тренера?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Coaches.Delete(ind);

                LoadData();
            }
        }
    }
}
