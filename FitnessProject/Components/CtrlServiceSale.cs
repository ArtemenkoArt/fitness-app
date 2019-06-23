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
    public partial class CtrlServiceSale : UserControl
    {
        #region Fields

        public int Id = 0;

        #endregion

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

        public CtrlServiceSale()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.ServiceSales.GetList(0, Date1, Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("ServiceName");
            dt.Columns.Add("DimensionName");
            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Quantity", typeof(double));
            dt.Columns.Add("User");
            dt.Columns.Add("Type");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Time");
            dt.Columns.Add("Summ", typeof(double));

            dt.Columns.Add("IsDeleted");
            dt.Columns.Add("DeleteDate", typeof(DateTime));
            dt.Columns.Add("DeleteReason");
            dt.Columns.Add("Id", typeof(int));


            int total = 0;
            double totalSumm = 0;
            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.ServiceSales.ServiceSales_WideDetails det = (DBLayer.ServiceSales.ServiceSales_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                if (!det.IsDeleted)
                {
                    total++;
                    totalSumm += (det.Cost * det.Quantity);
                }

                dr["ServiceName"] = det.ServiceName;
                dr["DimensionName"] = det.DimensionName;
                dr["Cost"] = det.Cost;
                dr["User"] = det.UserName;
                dr["Date"] = det.Date;
                dr["Time"] = det.Time;
                dr["Quantity"] = det.Quantity;
                dr["Summ"] = (det.Cost * det.Quantity);

                string name = string.Empty;

                switch (det.Type)
                {
                    case 0:
                        name = "Солярий";
                        break;
                    case 1:
                        name = "Массаж";
                        break;
                    case 2:
                        name = "Сауна";
                        break;
                    case 3:
                        name = "Косметология";
                        break;
                    case 4:
                        name = "Аренда";
                        break;
                }

                dr["Type"] = name;

                if (det.IsDeleted)
                    dr["IsDeleted"] = "Удален";

                if (det.DeleteDate != DateTime.MinValue)
                    dr["DeleteDate"] = det.DeleteDate;

                dr["DeleteReason"] = det.DeleteReason;

                dr["Id"] = det.Id;
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
                    total += summ;
            }

            slblTotalMoney.Text = total.ToString();
            slblTotal.Text = advBandedGridView1.RowCount.ToString();

            advBandedGridView1.BestFitColumns();
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
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
            DBLayer.ServiceSales.Details det = DBLayer.ServiceSales.GetDetails(this.Id);

            det.DeleteReason = args.Reason;
            det.DeleteDate = DateTime.Now;

            DBLayer.ServiceSales.SetDelete(det);

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
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventArgs args)
        {
            this.Date = new DateTime(args.Year, args.Month, 1);

            SetData(args.Month, args.Year);
        }

        private void tbtnChoose_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmSelectDate frm = new FitnessProject.ServiceForms.FrmSelectDate(this.Date.Month, this.Date.Year);
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmSelectDate.ChooseRangeEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        private void tbtnToday_Click(object sender, EventArgs e)
        {
            Date1 = DateTime.Now;
            Date2 = DateTime.Now;

            tbDateFrom.Text = Date1.ToString("dd-MMM-yyyy");
            tbDateTill.Text = Date2.ToString("dd-MMM-yyyy");

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

            this.Id = ind;
            ServiceForms.FrmCalendar frm3 = new FitnessProject.ServiceForms.FrmCalendar();
            frm3.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm3_SelectDateMsg);
            frm3.ShowDialog();
        }

        void frm3_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            DBLayer.ServiceSales.Details det = DBLayer.ServiceSales.GetDetails(this.Id);

            det.Date = args.SelectedDate;

            DBLayer.ServiceSales.Update(det);

            LoadData();
        }


    }
}
