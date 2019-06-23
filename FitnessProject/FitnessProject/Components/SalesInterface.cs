using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO.Ports;

namespace FitnessProject.Components
{
    public partial class SalesInterface : UserControl
    {
        #region Fields

        private DateTime Date1 = DateTime.Now;

        #endregion

        public SalesInterface()
        {
            InitializeComponent();

            
            Date1 = DateTime.Now;
            tbDateFrom.Text = Date1.ToString("dd-MMM-yyyy");
            LoadData();
            //port.Open();
        }

        #region LoadData

        public void LoadData()
        {
            ArrayList al = DBLayer.Products.GetProducts(Convert.ToDateTime(tbDateFrom.Text));

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Total", typeof(double));
            dt.Columns.Add("GroupName");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("DimensionName");
            dt.Columns.Add("Code");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.Products_WideDetails det = (DBLayer.Products.Products_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["GroupName"] = det.GroupName;
                dr["ProductName"] = det.Name;
                dr["DimensionName"] = det.DimensionName;
                dr["Code"] = det.Barcode;

                dr["Quantity"] = det.Sold;
                dr["Price"] = det.Price;
                dr["Total"] = det.Price * det.Sold;
                dr["Id"] = det.Id;
            }

            grSales.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void advBandedGridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == advBandedGridView1.Columns["Quantity"])
            {
                int quantity = Convert.ToInt32(advBandedGridView1.GetRowCellValue(e.RowHandle, "Quantity"));
                double price = Convert.ToDouble(advBandedGridView1.GetRowCellValue(e.RowHandle, "Price"));

                double total = price * quantity;

                advBandedGridView1.SetRowCellValue(e.RowHandle, "Total", total);
            }
        }

        private void tbtnSale_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                double total = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Total"));

                if (total > 0)
                {
                    int quantity = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Quantity"));


                    int id = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Id"));

                    DBLayer.Users.Details det = ((DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User"));

                    DBLayer.Sales.Details sDet = new FitnessProject.DBLayer.Sales.Details();

                    sDet.Date = this.Date1;
                    sDet.ProductId = id;
                    sDet.UserId = det.Id;
                    sDet.Quantity = quantity;

                    DBLayer.Sales.Insert(sDet);
                }
            }

            MessageBox.Show("Изменения сохранены");
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

        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            string code = indata;

            port.Close();

            try
            {

                DBLayer.Products.Details det = DBLayer.Products.GetDetails(code);

                for (int i = 0; i < advBandedGridView1.RowCount; i++)
                {
                    string barcode = advBandedGridView1.GetRowCellValue(i, "Code").ToString();

                    if (barcode == code)
                    {
                        int count = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Quantity"));

                        advBandedGridView1.SetRowCellValue(i, "Quantity", (count + 1));
                    }
                }

                tbtnSale_Click(sender, new EventArgs());
            }
            catch { }*/
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                string barcode = advBandedGridView1.GetRowCellValue(i, "Code").ToString();

                if (barcode.Length > 0)
                {
                    if (barcode.Substring(0, barcode.Length - 2) == "54491069")
                    {
                        int count = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Quantity"));

                        advBandedGridView1.SetRowCellValue(i, "Quantity", (count + 1));
                    }
                }
            }

            tbtnSale_Click(sender, new EventArgs());
        }
    }
}
