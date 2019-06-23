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
    public partial class CtrlBirthdays : UserControl
    {
        #region Fields

        public int Month = DateTime.Now.Month;

        #endregion

        public CtrlBirthdays()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Clients.GetBirthDates(this.Month);

            DataTable dt = new DataTable();

            dt.Columns.Add("FIO");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Birthdate", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Clients.Details det = (DBLayer.Clients.Details) al[i];

                DataRow dr = dt.Rows.Add();

                dr["FIO"] = det.FIO;
                dr["Birthdate"] = det.BirthDate;
                dr["Phone"] = det.Phone;
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

            LoadData();
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToXls(sfdExcel.FileName);
            }
        }
    }
}
