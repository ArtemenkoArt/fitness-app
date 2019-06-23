using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.Components
{
    public partial class CtrlArrivals : UserControl
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

        public CtrlArrivals()
        {
            InitializeComponent();
            advBandedGridView1.ColumnFilterChanged += new EventHandler(advBandedGridView1_ColumnFilterChanged);

            SetData(DateTime.Now.Month, DateTime.Now.Year);

            LoadData();
        }

        void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                total += Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Total"));
            }

            slblTotal.Text = total.ToString();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.ArrivalDetails.GetList(0, Date1, Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Total", typeof(double));
            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Good");
            dt.Columns.Add("Quantity", typeof(double));
            dt.Columns.Add("Supplier");
            dt.Columns.Add("Dimension");

            double total = 0;

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.ArrivalDetails.ArrivalDetails_WideDetails det = (DBLayer.ArrivalDetails.ArrivalDetails_WideDetails)al[i];

                dr["Id"] = det.Id;                
                dr["Supplier"] = det.SupplierName;
                dr["Date"] = det.Date;
                dr["Good"] = det.ProductName;
                dr["Quantity"] = det.Quantity;
                dr["Cost"] = det.Price;
                dr["Total"] = det.Price * det.Quantity;
                dr["Dimension"] = det.DimensionName;

                total += (det.Price * det.Quantity);
            }

            grGoods.DataSource = dt;
            advBandedGridView1.BestFitColumns();

            slblTotal.Text = total.ToString();
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditArrival frm = new FitnessProject.DataForms.FrmEditArrival();
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

            DataForms.FrmEditArrival frm = new FitnessProject.DataForms.FrmEditArrival(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить поставку?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                if (ind != 0)
                {

                    DBLayer.ArrivalDetails.Details det = DBLayer.ArrivalDetails.GetDetails(ind);

                    

                    DBLayer.ArrivalDetails.Delete(ind);

                    if (det.ChargeId != 0)
                    {
                        DBLayer.Charges.Delete(det.ChargeId);
                    }

                    LoadData();
                }
            }
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
            }
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
    }
}
