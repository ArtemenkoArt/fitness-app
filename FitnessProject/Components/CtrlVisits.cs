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
    public partial class CtrlVisits : UserControl
    {
        public DateTime Date1 = DateTime.Now.AddMonths(-1);
        public DateTime Date2 = DateTime.Now;

        public DateTime Date = DateTime.Now;

        public CtrlVisits()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);

            LoadData();
        }

        #region LoadData

        public void LoadData()
        {
            ArrayList al = DBLayer.Visits.GetList(Date1, Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("ClientID", typeof(int));
            dt.Columns.Add("FIO");
            dt.Columns.Add("Time");
            dt.Columns.Add("Card");
            dt.Columns.Add("AbonementName");
            dt.Columns.Add("BoxType");
            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("Coach");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("TimeOff");

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.Visits.Visits_WideDetails det = (DBLayer.Visits.Visits_WideDetails)al[i];

                dr["ClientID"] = det.ClientId;
                dr["FIO"] = det.ClientName;
                dr["Time"] = det.Time;

                dr["Date"] = det.Date;

                if (det.WithoutKey)
                    dr["Card"] = "Без карты";
                dr["Number"] = det.Number.ToString();

                dr["AbonementName"] = det.AbonementName;
                dr["BoxType"] = det.BoxType;

                dr["Coach"] = det.CoachName;

                dr["TimeOff"] = det.TimeOff;
            }

            grClients.DataSource = dt;

            slblTotal.Text = al.Count.ToString();

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
            }
        }

        private void tbtnView_Click(object sender, EventArgs e)
        {
            int[] i;
            int SelRow = -1;
            i = advBandedGridView1.GetSelectedRows();
            SelRow = i[0];

            int ind = 0;

            try
            {
                ind = Convert.ToInt32(advBandedGridView1.GetRowCellValue(SelRow, "ClientID"));
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                    
            ServiceForms.FrmViewClient frm = new FitnessProject.ServiceForms.FrmViewClient(DBLayer.Clients.GetDetails(ind));
            frm.ShowDialog();
        }

        #region SetData

        public void SetData(int month, int year)
        {
            Date1 = new DateTime(year, month, 1);
            Date2 = Date1.AddMonths(1).AddDays(-1);

            tbDateFrom.Text = Date1.ToString("dd-MMM-yyyy");
            tbDateTill.Text = Date2.ToString("dd-MMM-yyyy");

            LoadData();
        }

        #endregion

        void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            slblTotal.Text = advBandedGridView1.RowCount.ToString();
        }

        private void tbtnDateFrom_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm1 = new FitnessProject.ServiceForms.FrmCalendar();
            frm1.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm1_SelectDateMsg);
            frm1.ShowDialog();
        }

        void frm1_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDateFrom.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
            Date1 = args.SelectedDate;

            LoadData();
        }

        private void tbtnDateTill_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm2 = new FitnessProject.ServiceForms.FrmCalendar();
            frm2.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm2_SelectDateMsg);
            frm2.ShowDialog();
        }

        void frm2_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDateTill.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
            Date2 = args.SelectedDate;

            LoadData();
        }

        private void tbtnChoose_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmSelectDate frm = new FitnessProject.ServiceForms.FrmSelectDate(this.Date.Month, this.Date.Year);
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventArgs args)
        {
            this.Date = new DateTime(args.Year, args.Month, 1);

            SetData(args.Month, args.Year);

            //LoadData();
        }
    }
}
