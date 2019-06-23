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
    public partial class CtrlCoachesVisits : UserControl
    {
        #region Fields

        public int Month = DateTime.Now.Month;
        public int Year = DateTime.Now.Year;

        #endregion

        public CtrlCoachesVisits()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Coaches.VisitsReport(this.Month, this.Year);

            DataTable dt = new DataTable();

            dt.Columns.Add("FIO");
            dt.Columns.Add("Abonements", typeof(int));
            dt.Columns.Add("Single", typeof(int));
            dt.Columns.Add("Substitutions", typeof(int));
            dt.Columns.Add("Total", typeof(int));

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.VisitsReportDetails det = (DBLayer.Coaches.VisitsReportDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["FIO"] = det.Name;
                dr["Abonements"] = det.Abonements;
                dr["Single"] = det.Single;
                dr["Substitutions"] = det.Substitutions;
                dr["Total"] = det.Abonements + det.Single + det.Substitutions;
            }

            grSales.DataSource = dt;
            advBandedGridView1.BestFitColumns();

            slblCount.Text = al.Count.ToString();
        }

        #endregion

        private void grSales_Click(object sender, EventArgs e)
        {
            
        }


        private void tbtnMonth_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmSelectDate frm = new FitnessProject.ServiceForms.FrmSelectDate(DateTime.Now.Month, DateTime.Now.Year);
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventArgs args)
        {
            this.Month = args.Month;
            this.Year = args.Year;

            LoadData();
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
