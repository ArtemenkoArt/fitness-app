using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.Components
{
    public partial class CtrlChart : UserControl
    {
        public int Month { get; set; }
        public int Year { get; set; }

        public CtrlChart()
        {
            InitializeComponent();

            this.Year = DateTime.Now.Year;
            this.Month = DateTime.Now.Month;

            LoadData();
        }

        private void tbtnMonthChange_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmSelectDate frm = new ServiceForms.FrmSelectDate(DateTime.Now.Month, DateTime.Now.Year);
            frm.SelectDateMsg += new ServiceForms.FrmSelectDate.ChooseRangeEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        private void LoadData()
        {
            lvData.Items.Clear();

            var incomesList = DBLayer.AbonementIncome.MoneyReportByDayIncomes(this.Month, this.Year);
            var chargesList = DBLayer.AbonementIncome.MoneyReportByDayCharges(this.Month, this.Year);

            DateTime date = new DateTime(this.Year, this.Month, 1);

            DateTime dateEnd = date.AddMonths(1);

            while (date < dateEnd)
            {
                ListViewItem lvi = new ListViewItem();

                foreach (DBLayer.AbonementIncome.FinincialDetails det in chargesList)
                {
                    if (det.Date.Date == date.Date)
                    {
                        lvi.SubItems.Add(det.Value.ToString());
                        break;
                    }
                }

                foreach (DBLayer.AbonementIncome.FinincialDetails det in incomesList)
                {
                    if (det.Date.Date == date.Date)
                    {
                        lvi.SubItems.Add(det.Value.ToString());
                        break;
                    }
                }

                

                lvi.Text = date.ToShortDateString();

                lvData.Items.Add(lvi);

                date = date.AddDays(1);
            }
        }

        void frm_SelectDateMsg(object sender, ServiceForms.FrmSelectDate.ChooseRangeEventArgs args)
        {
            this.Year = args.Year;
            this.Month = args.Month;

            LoadData();
        }
    }
}
