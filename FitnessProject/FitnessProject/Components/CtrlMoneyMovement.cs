using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.Office;

namespace FitnessProject.Components
{
    public partial class CtrlMoneyMovement : UserControl
    {
        #region Fields

        public DateTime Date1 = DateTime.Now.AddMonths(-1);
        public DateTime Date2 = DateTime.Now;

        public DateTime Date = DateTime.Now;

        string[] alphabit = new string[26];

        public double Abonements = 0;
        public double Services = 0;
        public double Goods = 0;
        public double Charges = 0;

        #endregion

        #region Fill Alphabit
        private void FillAlphabit()
        {
            alphabit[0] = "A";
            alphabit[1] = "B";
            alphabit[2] = "C";
            alphabit[3] = "D";
            alphabit[4] = "E";
            alphabit[5] = "F";
            alphabit[6] = "G";
            alphabit[7] = "H";
            alphabit[8] = "I";
            alphabit[9] = "J";
            alphabit[10] = "K";
            alphabit[11] = "L";
            alphabit[12] = "M";
            alphabit[13] = "N";
            alphabit[14] = "O";
            alphabit[15] = "P";
            alphabit[16] = "Q";
            alphabit[17] = "R";
            alphabit[18] = "S";
            alphabit[19] = "T";
            alphabit[20] = "U";
            alphabit[21] = "V";
            alphabit[22] = "W";
            alphabit[23] = "X";
            alphabit[24] = "Y";
            alphabit[25] = "Z";
        }
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

        public CtrlMoneyMovement()
        {
            InitializeComponent();

            FillAlphabit();

            SetData(DateTime.Now.Month, DateTime.Now.Year);
            advBandedGridView1.ColumnFilterChanged += new EventHandler(advBandedGridView1_ColumnFilterChanged);
        }

        void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            double abon = 0;
            double goods = 0;
            double serv = 0;
            double charges = 0;

            double total = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                int type = Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Type"));
                double summ = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Total"));

                if (type == 0)
                    abon += summ;

                if (type == 1)
                    goods += summ;

                if (type == 2)
                    serv += summ;

                if (type == 3)
                    charges += summ;
            }

            this.Abonements = abon;
            this.Goods = goods;
            this.Services = serv;
            this.Charges = charges;

            slblIncome.Text = (abon + serv + goods).ToString();
            slblAbonements.Text = abon.ToString();
            slblGoods.Text = goods.ToString();
            slblServices.Text = serv.ToString();
            slblCharges.Text = charges.ToString();

            lblRest.Text = total.ToString();
            lblChargesBig.Text = charges.ToString();
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
            ArrayList al = DBLayer.AbonementIncome.MoneyReport(Date1, Date2);

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

            dt.Columns.Add("Cost", typeof(double));
            dt.Columns.Add("Quantity", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Time");
            dt.Columns.Add("Type", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("ChargeGroupName");

            dt.Columns.Add("AbonementType");

            //lvData.Items.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AbonementIncome.Money_ReportDetails det = (DBLayer.AbonementIncome.Money_ReportDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Group"] = det.GroupName;
                dr["Good"] = det.AbonementName;
                dr["Dimension"] = det.DimensionName;

                dr["User"] = det.UserName;
                if (det.Type != 3)
                {
                    dr["Cost"] = det.Price;
                    dr["Quantity"] = det.Quantity;
                }

                dr["Total"] = det.Summ;
                dr["Time"] = det.Time;

                dr["Date"] = det.Date;

                dr["Name"] = det.Name;

                dr["ChargeGroupName"] = det.ChargeGroupName;

                if (det.Type == 0)
                    abon += det.Summ;

                if (det.Type == 1)
                    goods += det.Summ;

                if (det.Type == 2)
                    serv += det.Summ;

                if (det.Type == 3)
                    charges += det.Summ;

                dr["Type"] = det.Type;

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

            this.Abonements = abon;
            this.Goods = goods;
            this.Services = serv;
            this.Charges = charges;

            total = abon + goods + serv + charges;

            grSales.DataSource = dt;

            advBandedGridView1.BestFitColumns();

            slblIncome.Text = (abon + serv + goods).ToString();
            slblAbonements.Text = abon.ToString();
            slblGoods.Text = goods.ToString();
            slblServices.Text = serv.ToString();
            slblCharges.Text = charges.ToString();

            lblRest.Text = total.ToString();
            lblChargesBig.Text = charges.ToString();
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
                advBandedGridView1.ExportToExcelOld(sfdExcel.FileName);

            //GenerateExcel();
        }

        #region GenerateExcel

        public void GenerateExcel()
        {
            Microsoft.Office.Interop.Excel.ApplicationClass xl;

            xl = new Microsoft.Office.Interop.Excel.ApplicationClass();

            xl.Visible = false;

            Microsoft.Office.Interop.Excel.Workbooks books = (Microsoft.Office.Interop.Excel.Workbooks)xl.Workbooks;

            Microsoft.Office.Interop.Excel.Workbook book = books.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;

            sheet.Name = "Касса";

            Microsoft.Office.Interop.Excel.Range rd;
            Microsoft.Office.Interop.Excel.Range rd1;
            Microsoft.Office.Interop.Excel.Range rd2;
            Microsoft.Office.Interop.Excel.Range rd3;
            Microsoft.Office.Interop.Excel.Range rd4;
            Microsoft.Office.Interop.Excel.Range rd5;
            Microsoft.Office.Interop.Excel.Range rd6;
            Microsoft.Office.Interop.Excel.Range rd7;
            Microsoft.Office.Interop.Excel.Range rd8;
            Microsoft.Office.Interop.Excel.Range rd9;
            Microsoft.Office.Interop.Excel.Range rd10;
            Microsoft.Office.Interop.Excel.Range rd11;

            Microsoft.Office.Interop.Excel.Range rd12;
            Microsoft.Office.Interop.Excel.Range rd13;
            Microsoft.Office.Interop.Excel.Range rd14;
            Microsoft.Office.Interop.Excel.Range rd15;
            Microsoft.Office.Interop.Excel.Range rd16;

            Microsoft.Office.Interop.Excel.Range rd17;
            Microsoft.Office.Interop.Excel.Range rd18;
            Microsoft.Office.Interop.Excel.Range rd19;
            Microsoft.Office.Interop.Excel.Range rd20;
            Microsoft.Office.Interop.Excel.Range rd21;

            Microsoft.Office.Interop.Excel.Range rd22;
            Microsoft.Office.Interop.Excel.Range rd23;
            Microsoft.Office.Interop.Excel.Range rd24;
            Microsoft.Office.Interop.Excel.Range rd25;
            Microsoft.Office.Interop.Excel.Range rd26;
            Microsoft.Office.Interop.Excel.Range rd27;

            Microsoft.Office.Interop.Excel.Range rd28;
            Microsoft.Office.Interop.Excel.Range rd29;

            Microsoft.Office.Interop.Excel.Range rd30;

            Microsoft.Office.Interop.Excel.Range rd31;
            Microsoft.Office.Interop.Excel.Range rd32;
            Microsoft.Office.Interop.Excel.Range rd33;
            Microsoft.Office.Interop.Excel.Range rd34;
            Microsoft.Office.Interop.Excel.Range rd35;

            Microsoft.Office.Interop.Excel.Range rd36;
            Microsoft.Office.Interop.Excel.Range rd37;
            Microsoft.Office.Interop.Excel.Range rd38;
            Microsoft.Office.Interop.Excel.Range rd39;
            Microsoft.Office.Interop.Excel.Range rd40;
            Microsoft.Office.Interop.Excel.Range rd41;

            Microsoft.Office.Interop.Excel.Range rd42;
            Microsoft.Office.Interop.Excel.Range rd43;
            Microsoft.Office.Interop.Excel.Range rd44;
            Microsoft.Office.Interop.Excel.Range rd45;

            rd = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, "C"];

            rd.Value2 = "Касса";
            rd.Font.Bold = true;

            rd1 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[2, "B"];

            rd1.Value2 = "за период с";
            rd1.ColumnWidth = 12;

            rd2 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[2, "C"];

            rd2.Value2 = this.Date1.ToString("dd-MMM-yyyy");

            rd3 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[2, "D"];

            rd3.Value2 = " по ";
            rd3.ColumnWidth = 3;

            rd4 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[2, "E"];

            rd4.Value2 = this.Date2.ToString("dd-MMM-yyyy");

            rd5 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[4, "A"], sheet.Cells[4, "D"]);
            rd5.MergeCells = true;
            rd5.Font.Bold = true;
            rd5.Value2 = "Абонементы";

            rd6 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[4, "E"];

            rd6.Value2 = this.Abonements.ToString();

            int ind = 6;

            rd30 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "A"];
            rd30.Value2 = "Абонемент";
            rd30.Font.Bold = true;
            rd30.ColumnWidth = 35;

            rd31 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "B"];
            rd31.Value2 = "Дата";
            rd31.Font.Bold = true;
            rd31.ColumnWidth = 10;

            rd32 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "C"];
            rd32.Value2 = "Стоимость";
            rd32.Font.Bold = true;
            rd32.ColumnWidth = 10;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Type")) == 0)
                {
                    rd7 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[6 + i, "A"];
                    rd7.Value2 = advBandedGridView1.GetRowCellValue(i, "Good");
                    rd7.ColumnWidth = 35;

                    rd8 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[6 + i, "B"];
                    rd8.Value2 = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(i, "Date")).ToString("dd-MMM-yyyy");
                    rd8.ColumnWidth = 10;

                    rd9 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[6 + i, "C"];
                    rd9.Value2 = advBandedGridView1.GetRowCellValue(i, "Cost");
                    rd9.ColumnWidth = 10;

                    ind += 1;
                }
            }

            rd10 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[ind + 2, "A"], sheet.Cells[ind + 2, "D"]);
            rd10.MergeCells = true;
            rd10.Font.Bold = true;
            rd10.Value2 = "Товары";

            rd11 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + 2, "E"];

            rd11.Value2 = this.Goods.ToString();

            ind += 4;

            rd33 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "A"];
            rd33.Value2 = "Товар";
            rd33.Font.Bold = true;
            rd33.ColumnWidth = 35;

            rd34 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "B"];
            rd34.Value2 = "Дата продажи";
            rd34.Font.Bold = true;
            rd34.ColumnWidth = 12;

            rd35 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "C"];
            rd35.Font.Bold = true;
            rd35.Value2 = "Цена";
            rd35.ColumnWidth = 10;

            rd36 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "D"];
            rd36.Font.Bold = true;
            rd36.Value2 = "Количество";
            rd36.ColumnWidth = 12;

            rd37 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "E"];
            rd37.Value2 = "Итого";
            rd37.Font.Bold = true;
            rd37.ColumnWidth = 12;

            int newInt = ind;

            int servInd = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Type")) == 1)
                {
                    rd12 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd, "A"];
                    rd12.Value2 = advBandedGridView1.GetRowCellValue(i, "Good");
                    rd12.ColumnWidth = 35;

                    rd13 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd, "B"];
                    rd13.Value2 = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(i, "Date")).ToString("dd-MMM-yyyy");
                    rd13.ColumnWidth = 10;

                    rd14 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd, "C"];
                    rd14.Value2 = advBandedGridView1.GetRowCellValue(i, "Cost");
                    rd14.ColumnWidth = 10;

                    rd14 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd, "D"];
                    rd14.Value2 = advBandedGridView1.GetRowCellValue(i, "Quantity");
                    rd14.ColumnWidth = 10;

                    rd28 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd, "E"];
                    rd28.Value2 = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Quantity")) * Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Cost"));
                    rd28.ColumnWidth = 10;

                    newInt += 1;
                }
                else
                {
                    servInd += 1;
                }
            }

            ind = newInt;

            rd15 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[ind + 2, "A"], sheet.Cells[ind + 2, "D"]);
            rd15.MergeCells = true;
            rd15.Font.Bold = true;
            rd15.Value2 = "Услуги";

            rd16 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + 2, "E"];

            rd16.Value2 = this.Services.ToString();

            ind = ind + 4;

            rd38 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "A"];
            rd38.Value2 = "Услуга";
            rd38.Font.Bold = true;
            rd38.ColumnWidth = 35;

            rd39 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "B"];
            rd39.Value2 = "Дата продажи";
            rd39.Font.Bold = true;
            rd39.ColumnWidth = 12;

            rd40 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "C"];
            rd40.Value2 = "Цена";
            rd40.Font.Bold = true;
            rd40.ColumnWidth = 12;

            rd41 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "D"];
            rd41.Value2 = "Количество";
            rd41.Font.Bold = true;
            rd41.ColumnWidth = 12;

            rd42 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "E"];
            rd42.Value2 = "Итого";
            rd42.ColumnWidth = 12;
            rd42.Font.Bold = true;

            int newInt2 = ind;

            int servInd2 = 0;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Type")) == 2)
                {
                    rd17 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd2, "A"];
                    rd17.Value2 = advBandedGridView1.GetRowCellValue(i, "Good");
                    rd17.ColumnWidth = 35;

                    rd18 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd2, "B"];
                    rd18.Value2 = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(i, "Date")).ToString("dd-MMM-yyyy");
                    rd18.ColumnWidth = 12;

                    rd19 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd2, "C"];
                    rd19.Value2 = advBandedGridView1.GetRowCellValue(i, "Cost");
                    rd19.ColumnWidth = 12;

                    rd20 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd2, "D"];
                    rd20.Value2 = advBandedGridView1.GetRowCellValue(i, "Quantity");
                    rd20.ColumnWidth = 12;

                    rd29 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd2, "E"];
                    rd29.Value2 = Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Quantity")) * Convert.ToDouble(advBandedGridView1.GetRowCellValue(i, "Cost"));
                    rd29.ColumnWidth = 12;

                    newInt2 += 1;
                }
                else
                {
                    servInd2 += 1;
                }
            }

            ind = newInt2 + 2;

            rd21 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[ind, "A"], sheet.Cells[ind, "D"]);
            rd21.MergeCells = true;
            rd21.Font.Bold = true;
            rd21.Value2 = "Расходы";

            rd22 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind, "E"];

            rd22.Value2 = this.Charges.ToString();

            int val = ind;

            ind = ind + 2;

            int newInt3 = ind;

            int servInd3 = 0;

            rd43 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "A"];
            rd43.Value2 = "Название";
            rd43.Font.Bold = true;
            rd43.ColumnWidth = 35;

            rd44 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "B"];
            rd44.Value2 = "Дата";
            rd44.Font.Bold = true;
            rd44.ColumnWidth = 10;

            rd45 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind - 1, "C"];
            rd45.Value2 = "Сумма";
            rd45.Font.Bold = true;
            rd45.ColumnWidth = 10;

            for (int i = 0; i < advBandedGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(advBandedGridView1.GetRowCellValue(i, "Type")) == 3)
                {
                    rd23 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd3, "A"];
                    rd23.Value2 = advBandedGridView1.GetRowCellValue(i, "Good");
                    rd23.ColumnWidth = 35;

                    rd24 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd3, "B"];
                    rd24.Value2 = Convert.ToDateTime(advBandedGridView1.GetRowCellValue(i, "Date")).ToString("dd-MMM-yyyy");
                    rd24.ColumnWidth = 10;

                    rd25 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + i - servInd3, "C"];
                    rd25.Value2 = advBandedGridView1.GetRowCellValue(i, "Total");
                    rd25.ColumnWidth = 10;

                    newInt3 += 1;
                }
                else
                {
                    servInd3 += 1;
                }
            }

            ind = newInt3 + 2;

            int valFinish = ind;

            Microsoft.Office.Interop.Excel.Range rd47 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[val, "A"], sheet.Cells[valFinish, "F"]);

            rd47 = (Microsoft.Office.Interop.Excel.Range)sheet.get_Range(sheet.Cells[ind, "A"], sheet.Cells[ind, "E"]);
            rd47.MergeCells = true;
            rd47.Font.Bold = true;
            rd47.Value2 = "Сальдо";

            rd47 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[ind + 1, "G"];

            rd47.Value2 = (this.Abonements + this.Goods + this.Services + this.Charges).ToString();

            xl.Visible = true;
        }

        #endregion

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
    }
}
