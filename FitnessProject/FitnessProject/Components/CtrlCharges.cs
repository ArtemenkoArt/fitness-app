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
    public partial class CtrlCharges : UserControl
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

        public CtrlCharges()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);

            LoadData();

            DBLayer.Users.Details det = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            if (det.IsAdmin)
                tbtnRemove.Visible = true;
            else
                tbtnRemove.Visible = false;
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Charges.GetList(Date1, Date2);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Summ", typeof(double));
            dt.Columns.Add("GroupName");
            dt.Columns.Add("Name");

            double total = 0;

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Charges.Charges_WideDetails det = (DBLayer.Charges.Charges_WideDetails) al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["GroupName"] = det.GroupName;
                dr["Date"] = det.Date;
                dr["Name"] = det.Name;
                dr["Summ"] = det.Summ;

                total += det.Summ;
            }

            lblTotal.Text = total.ToString();

            grCharges.DataSource = dt;

            advBandedGridView1.BestFitColumns();
        }        

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditCharge frm = new FitnessProject.DataForms.FrmEditCharge();
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

            DataForms.FrmEditCharge frm = new FitnessProject.DataForms.FrmEditCharge(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить расход?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                                
                DBLayer.Charges.Delete(ind);

                LoadData();
            }
        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                double summ = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Summ"));

                total += summ;
            }

            lblTotal.Text = total.ToString();

            advBandedGridView1.BestFitColumns();
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
