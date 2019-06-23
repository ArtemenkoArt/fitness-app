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
    public partial class CtrlRests : UserControl
    {
        #region Fields

        public DateTime Date1 = DateTime.Now.AddYears(-1);
        public DateTime Date2 = DateTime.Now;

        #endregion

        public CtrlRests()
        {
            InitializeComponent();

            LoadData();
        }

        



        

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Products.GetRest(Date1, Date2);

            double abon = 0;
            double goods = 0;
            double serv = 0;
            double charges = 0;

            double total = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("Dimension");
            dt.Columns.Add("Group");
            dt.Columns.Add("Good");
            
            dt.Columns.Add("Total", typeof(double));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Cap", typeof(double));
            dt.Columns.Add("Id", typeof(int));  
            
            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.Rest_Details det = (DBLayer.Products.Rest_Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Group"] = det.GroupName;
                dr["Good"] = det.ProductName;
                dr["Dimension"] = det.DimensionName;

                dr["Id"] = det.Id;

                if (det.Rest >= 0)
                {
                    dr["Total"] = det.Rest;
                }

                dr["Price"] = det.Price;

                if (det.Rest >= 0)
                {
                    dr["Cap"] = det.Rest * det.Price;
                }

                if (det.Rest >= 0)
                {
                    total += (det.Rest * det.Price);
                }
            }

            lblTotal.Text = total.ToString();

            grSales.DataSource = dt;

            advBandedGridView1.BestFitColumns();            
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);
        }

        private void btnDateStartSelect_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frmC1 = new FitnessProject.ServiceForms.FrmCalendar();
            frmC1.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frmC1_SelectDateMsg);
            frmC1.ShowDialog();
        }

        void frmC1_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDateStart.Text = args.SelectedDate.ToString("dd-MMM-yyyy");

            this.Date1 = args.SelectedDate;

            LoadData();
        }

        private void btnDateFinishSelect_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frmC2 = new FitnessProject.ServiceForms.FrmCalendar();
            frmC2.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frmC2_SelectDateMsg);
            frmC2.ShowDialog();
        }

        void frmC2_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDateFinish.Text = args.SelectedDate.ToString("dd-MMM-yyyy");

            this.Date2 = args.SelectedDate;

            LoadData();
        }

        private void tbDateStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.Date1 = DateTime.Now.AddYears(-1);
                tbDateStart.Text = "";

                LoadData();
            }
        }

        private void tbDateFinish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.Date2 = DateTime.Now;
                tbDateFinish.Text = "";

                LoadData();
            }
        }

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
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

            DataForms.FrmMovement frm = new FitnessProject.DataForms.FrmMovement(ind);
            frm.ShowDialog();
        }
    }
}
