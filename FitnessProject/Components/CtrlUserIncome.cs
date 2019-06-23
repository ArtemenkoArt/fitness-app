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
    public partial class CtrlUserIncome : UserControl
    {
        #region Fields

        public DateTime Date1 = DateTime.Now.AddMonths(-1);
        public DateTime Date2 = DateTime.Now;

        public DateTime Date = new DateTime();

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

        public CtrlUserIncome()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);

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
            ArrayList al = DBLayer.Users.GetUserIncome(this.Date1, this.Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("User");
            dt.Columns.Add("PercentForClients", typeof(double));
            dt.Columns.Add("PercentForGoods", typeof(double));
            dt.Columns.Add("PercentForService", typeof(double));
            dt.Columns.Add("Constant", typeof(double));
            dt.Columns.Add("AbonementIncome", typeof(double));
            dt.Columns.Add("GoodsIncome", typeof(double));
            dt.Columns.Add("ServiceIncome", typeof(double));
            dt.Columns.Add("Abonements", typeof(double));
            dt.Columns.Add("Goods", typeof(double));
            dt.Columns.Add("Services", typeof(double));
            dt.Columns.Add("Total", typeof(double));
            dt.Columns.Add("AbonementFitness", typeof(double));
            dt.Columns.Add("ServiceMassage", typeof(double));
            dt.Columns.Add("ServiceMassageIncome", typeof(double));
            dt.Columns.Add("ClientFitnessIncome", typeof(double));

            double total = 0;

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Users.UserIncome_Details det = (DBLayer.Users.UserIncome_Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["User"] = det.User;
                dr["PercentForClients"] = det.PercentForClients;
                dr["PercentForGoods"] = det.PercentForSales;
                dr["PercentForService"] = det.PercentForService;
                dr["Constant"] = det.Constant;
                dr["AbonementIncome"] = det.ClientIncome;
                dr["GoodsIncome"] = det.GoodIncome;
                dr["ServiceIncome"] = det.ServiceIncome;
                dr["Abonements"] = det.Abonements;
                dr["Goods"] = det.Goods;
                dr["Services"] = det.Services;
                dr["AbonementFitness"] = det.Fitness;
                dr["ServiceMassageIncome"] = det.MassageIncome;
                dr["ServiceMassage"] = det.Massage;
                dr["ClientFitnessIncome"] = det.FitnessIncome;
                dr["Total"] = det.ClientIncome + det.GoodIncome + det.ServiceIncome;

                total += det.Constant + det.ClientIncome + det.GoodIncome + det.ServiceIncome;
            }

            lblRest.Text = total.ToString();
            
            grSales.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                double summ = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "UserIncome"));

                total += summ;
            }

            lblRest.Text = total.ToString();
        }

        private void tbtnMonth_Click(object sender, EventArgs e)
        {
            Date = DateTime.Now;

            SetData(DateTime.Now.Month, DateTime.Now.Year);    
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
