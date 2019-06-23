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
    public partial class CtrlUserVisits : UserControl
    {
        public CtrlUserVisits()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.UserVisits.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("User");
            dt.Columns.Add("TimeOn");
            dt.Columns.Add("TimeOff");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.UserVisits.UserVisits_WideDetails det = (DBLayer.UserVisits.UserVisits_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Date"] = det.Date;
                dr["User"] = det.UserFIO;
                dr["TimeOn"] = det.TimeOn;
                dr["TimeOff"] = det.TimeOff;
            }

            grVisits.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void grVisits_Click(object sender, EventArgs e)
        {
            
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
