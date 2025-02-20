﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.Components
{
    public partial class CtrlAbonementSale : UserControl
    {
        #region Fields

        public DateTime Date1 = DateTime.Now.AddMonths(-1);
        public DateTime Date2 = DateTime.Now;

        public DateTime Date = DateTime.Now;

        #endregion

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

        #region Fields

        private int Id = 0;

        #endregion

        public CtrlAbonementSale()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);
            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.AbonementIncome.GetList(0, Date1, Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("AbonementName");
            dt.Columns.Add("CoachName");
            dt.Columns.Add("Weekday");
            dt.Columns.Add("Time");
            dt.Columns.Add("Client");
            dt.Columns.Add("User");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Summ", typeof(double));

            dt.Columns.Add("IsDeleted");
            dt.Columns.Add("DeleteDate", typeof(DateTime));
            dt.Columns.Add("DeleteReason");
            dt.Columns.Add("Id", typeof(int));

            dt.Columns.Add("AbonementType");


            int total = 0;
            double totalSumm = 0;
            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AbonementIncome.AbonementIncome_WideDetails det = (DBLayer.AbonementIncome.AbonementIncome_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();



                if (!det.IsDeleted)
                {
                    totalSumm += det.Summ;
                    total++;
                }

                dr["AbonementName"] = det.AbonementName;
                dr["Client"] = det.FIO;
                dr["User"] = det.User;
                dr["Date"] = det.Date;
                dr["Summ"] = det.Summ;

                dr["CoachName"] = det.CoachName;
                dr["Weekday"] = det.Weekday;
                dr["Time"] = det.Time;

                if (det.IsDeleted)
                    dr["IsDeleted"] = "Удален";

                if (det.DeleteDate != DateTime.MinValue)
                    dr["DeleteDate"] = det.DeleteDate;

                dr["DeleteReason"] = det.DeleteReason;

                dr["Id"] = det.Id;

                string name = "";

                switch (det.AbonementGroup)
                {
                    case 0:
                        name = "Тренажерный зал";
                        break;
                    case 1:
                        name = "Аэробный зал";
                        break;
                    default:
                        name = "";
                        break;
                }

                dr["AbonementType"] = name;
            }

            grSales.DataSource = dt;

            slblTotal.Text = total.ToString();
            slblTotalMoney.Text = totalSumm.ToString();

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                double summ = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Summ"));
                bool deleted = (Convert.ToString(advBandedGridView1.GetRowCellValue(i, "IsDeleted")) != "");

                if (!deleted)
                {
                    total += summ;
                }
            }

            slblTotalMoney.Text = total.ToString();
            slblTotal.Text = advBandedGridView1.RowCount.ToString();

            advBandedGridView1.BestFitColumns();
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                //advBandedGridView1.ExportToExcel(sfdExcel.FileName);
            }
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
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

            this.Id = ind;

            ServiceForms.FrmDeleteReason frm = new FitnessProject.ServiceForms.FrmDeleteReason();
            frm.SelectReasonMsg += new FitnessProject.ServiceForms.FrmDeleteReason.ReasonEventHandler(frm_SelectReasonMsg);
            frm.ShowDialog();
        }

        void frm_SelectReasonMsg(object sender, FitnessProject.ServiceForms.ReasonEventArgs args)
        {
            DBLayer.AbonementIncome.Details det = DBLayer.AbonementIncome.GetDetails(this.Id);

            det.DeleteReason = args.Reason;
            det.DeleteDate = DateTime.Now;

            DBLayer.AbonementIncome.SetDelete(det);

            LoadData();
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

        private void tbtnMonth_Click(object sender, EventArgs e)
        {
            Date = DateTime.Now;

            SetData(DateTime.Now.Month, DateTime.Now.Year);

            LoadData();
        }

        private void tbtnToday_Click(object sender, EventArgs e)
        {
            this.Date1 = DateTime.Now;
            this.Date2 = DateTime.Now;

            tbDateFrom.Text = Date1.ToString("dd-MMM-yyyy");
            tbDateTill.Text = Date2.ToString("dd-MMM-yyyy");

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

            this.Id = ind;
            ServiceForms.FrmCalendar frm3 = new FitnessProject.ServiceForms.FrmCalendar();
            frm3.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm3_SelectDateMsg);
            frm3.ShowDialog();
        }

        void frm3_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            DBLayer.AbonementIncome.Details det = DBLayer.AbonementIncome.GetDetails(this.Id);

            det.Date = args.SelectedDate;

            DBLayer.AbonementIncome.Update(det);

            LoadData();
        }
    }
}
