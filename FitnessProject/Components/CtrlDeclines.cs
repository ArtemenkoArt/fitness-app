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
    public partial class CtrlDeclines : UserControl
    {
        #region Fields

        public DateTime Date1 = DateTime.Now.AddMonths(-1);
        public DateTime Date2 = DateTime.Now;

        #endregion

        public CtrlDeclines()
        {
            InitializeComponent();

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

        private void tbDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbDateFrom.Text = "";
                Date1 = DateTime.Now;

                LoadData();
            }
        }

        private void tbDateTill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbDateTill.Text = "";
                Date2 = DateTime.Now;

                LoadData();
            }   
        }

        private void tbtnToday_Click(object sender, EventArgs e)
        {
            Date1 = DateTime.Now;
            Date2 = DateTime.Now;

            tbDateFrom.Text = Date1.ToString("dd-MMM-yyyy");
            tbDateTill.Text = Date2.ToString("dd-MMM-yyyy");

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.AbonementIncome.Decline(Date1, Date2);

            double abon = 0;
            double goods = 0;
            double serv = 0;
            double charges = 0;

            double total = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("Dimension");
            dt.Columns.Add("Group");
            dt.Columns.Add("Good");
            dt.Columns.Add("User");

            dt.Columns.Add("DeleteReason");
            dt.Columns.Add("DeleteDate", typeof(DateTime));

            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Quantity", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Time");

            //lvData.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AbonementIncome.Money_ReportDetails det = (DBLayer.AbonementIncome.Money_ReportDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Group"] = det.GroupName;
                dr["Good"] = det.Name;
                dr["Dimension"] = det.DimensionName;

                dr["User"] = det.UserName;
                dr["Cost"] = det.Price;
                dr["Quantity"] = det.Quantity;

                dr["Total"] = det.Summ;
                dr["Time"] = det.Time;

                dr["DeleteReason"] = det.DeleteReason;
                dr["DeleteDate"] = det.DeleteDate;

                if (det.Type == 0)
                    abon += det.Summ;

                if (det.Type == 1)
                    goods += det.Summ;

                if (det.Type == 2)
                    serv += det.Summ;                          
            }

            total = abon + goods + serv + charges;

            grSales.DataSource = dt;

            advBandedGridView1.BestFitColumns();

            slblAbonements.Text = abon.ToString();
            slblGoods.Text = goods.ToString();
            slblServices.Text = serv.ToString();
           
            lblRest.Text = total.ToString();           
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double abon = 0;
            double goods = 0;
            double serv = 0;
            double charges = 0;

            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                
                //total += summ;
            }

            lblRest.Text = total.ToString();
        }
    }
}
