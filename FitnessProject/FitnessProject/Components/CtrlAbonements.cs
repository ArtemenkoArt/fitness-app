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
    public partial class CtrlAbonements : UserControl
    {
        public CtrlAbonements()
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
            ArrayList al = DBLayer.Abonements.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Length", typeof(double));
            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Type");
            dt.Columns.Add("LessonsCount", typeof(int));
            dt.Columns.Add("AdditionalVisits", typeof(int));
            dt.Columns.Add("Single");
            dt.Columns.Add("CoachName");
            dt.Columns.Add("Unlim");
            dt.Columns.Add("Time");
            dt.Columns.Add("Weekdays");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Abonements.WideDetails det = (DBLayer.Abonements.WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Name"] = det.Name;

                dr["Length"] = det.Length;

                dr["Cost"] = det.Cost;

                dr["Weekdays"] = det.Weekdays;

                if (det.AbonementGroup == 0)
                    dr["Type"] = "Тренажерный зал";
                else
                    dr["Type"] = "Аэробный зал";

                if (det.LessonsCount > 0)
                {
                    dr["LessonsCount"] = det.LessonsCount;
                }

                if (det.IsSingle)
                    dr["Single"] = "Разовый";

                if (det.IsUnlim)
                    dr["Unlim"] = "Безлимитный";

                dr["CoachName"] = det.CoachName;

                dr["Time"] = det.Time;

                dr["AdditionalVisits"] = det.AdditionalVisits;

            }

            grSources.DataSource = dt;

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditAbonement frm = new FitnessProject.DataForms.FrmEditAbonement();
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

            DataForms.FrmEditAbonement frm = new FitnessProject.DataForms.FrmEditAbonement(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить абонемент?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Abonements.Delete(ind);

                LoadData();
            }
        }
    }
}
