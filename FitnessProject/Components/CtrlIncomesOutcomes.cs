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
    public partial class CtrlIncomesOutcomes : UserControl
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
        private ArrayList Al = new ArrayList();


        #endregion

        public CtrlIncomesOutcomes()
        {
            InitializeComponent();

            SetData(DateTime.Now.Month, DateTime.Now.Year);
            LoadData();

            tvdgAbonements.Width = pnlAbonements.Width;
            tvdgCharges.Width = pnlCharges.Width;
            tvdgGoods.Width = pnlBar.Width;
            tvdgServices.Width = pnlServices.Width;
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.AbonementIncome.MoneyReport(Date1, Date2);

            this.Al = al;

            double total = 0;

            double abonements = 0;
            double goods = 0;
            double services = 0;
            double charges = 0;

            tvdgCharges.Nodes.Clear();
            tvdgAbonements.Nodes.Clear();
            tvdgGoods.Nodes.Clear();
            tvdgServices.Nodes.Clear();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AbonementIncome.Money_ReportDetails det = (DBLayer.AbonementIncome.Money_ReportDetails)al[i];

                total += det.Summ;

                switch (det.Type)
                {
                    case 0:
                        
                        abonements += det.Summ;

                        bool abonAdd = true;
                        string abonName = det.AbonementName;
                        

                        for (int j = 0; j < tvdgAbonements.Nodes.Count; j++)
                        {
                            //abons.Add(det);
                            if (det.AbonementName == tvdgAbonements.Nodes[j].Cells["colNameAbon"].Value.ToString())
                            {
                                abonAdd = false;
                            }
                            else
                            {
                                abonName = det.AbonementName;
                            }
                        }

                        if (abonAdd)
                        {
                            double summ = 0;
                            ArrayList abons = new ArrayList();

                            for (int k = 0; k < al.Count; k++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detAb = (DBLayer.AbonementIncome.Money_ReportDetails)al[k];

                                if (detAb.AbonementName == abonName)
                                {
                                    abons.Add(detAb);

                                    summ += det.Summ;
                                }
                            }
                            AdvancedDataGridView.TreeGridNode node = tvdgAbonements.Nodes.Add(det.AbonementName, summ);

                            for (int x = 0; x < abons.Count; x++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detAbX = (DBLayer.AbonementIncome.Money_ReportDetails)abons[x];

                                node.Nodes.Add(detAbX.Name, det.Summ);
                            }
                        }
                        

                        break;
                    case 1:
                        goods += det.Summ;

                        

                        bool goodAdd = true;
                        string goodName = det.AbonementName;


                        for (int j = 0; j < tvdgGoods.Nodes.Count; j++)
                        {
                            //abons.Add(det);
                            if (det.AbonementName == tvdgGoods.Nodes[j].Cells["colNameGood"].Value.ToString())
                            {
                                goodAdd = false;
                            }
                            else
                            {
                                goodName = det.AbonementName;
                            }
                        }

                        if (goodAdd)
                        {
                            double summ = 0;
                            ArrayList goodsAL = new ArrayList();

                            for (int k = 0; k < al.Count; k++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detG = (DBLayer.AbonementIncome.Money_ReportDetails)al[k];

                                if (detG.AbonementName == goodName)
                                {
                                    goodsAL.Add(detG);

                                    summ += detG.Summ;
                                }
                            }
                            AdvancedDataGridView.TreeGridNode node = tvdgGoods.Nodes.Add(det.AbonementName, summ);

                            for (int x = 0; x < goodsAL.Count; x++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detGX = (DBLayer.AbonementIncome.Money_ReportDetails)goodsAL[x];

                                node.Nodes.Add(detGX.Date.ToString("dd-MMM-yyyy") + "/" + detGX.Quantity.ToString(), detGX.Summ);
                            }
                        }
                        break;
                    case 2:
                        services += det.Summ;

                        

                        bool servAdd = true;
                        string servName = det.AbonementName;


                        for (int j = 0; j < tvdgServices.Nodes.Count; j++)
                        {
                            //abons.Add(det);
                            if (det.AbonementName == tvdgServices.Nodes[j].Cells["colNameService"].Value.ToString())
                            {
                                servAdd = false;
                            }
                            else
                            {
                                servName = det.AbonementName;
                            }
                        }

                        if (servAdd)
                        {
                            double summ = 0;
                            ArrayList servAL = new ArrayList();

                            for (int k = 0; k < al.Count; k++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detS = (DBLayer.AbonementIncome.Money_ReportDetails)al[k];

                                if (detS.AbonementName == servName)
                                {
                                    servAL.Add(detS);

                                    summ += detS.Summ;
                                }
                            }
                            AdvancedDataGridView.TreeGridNode node = tvdgServices.Nodes.Add(det.AbonementName, summ);

                            for (int x = 0; x < servAL.Count; x++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detSX = (DBLayer.AbonementIncome.Money_ReportDetails)servAL[x];

                                node.Nodes.Add(detSX.Date.ToString("dd-MMM-yyyy") + "/" + detSX.Quantity.ToString(), detSX.Summ);
                            }
                        }

                        break;
                    case 3:
                        charges += det.Summ;

                        

                        bool chAdd = true;
                        string chName = det.ChargeGroupName;


                        for (int j = 0; j < tvdgCharges.Nodes.Count; j++)
                        {
                            //abons.Add(det);
                            if (det.ChargeGroupName == tvdgCharges.Nodes[j].Cells["colNameCharge"].Value.ToString())
                            {
                                chAdd = false;
                            }
                            else
                            {
                                chName = det.ChargeGroupName;
                            }

                            
                        }

                        if (chAdd)
                        {
                            double summ = 0;
                            ArrayList chAL = new ArrayList();

                            for (int k = 0; k < al.Count; k++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detC = (DBLayer.AbonementIncome.Money_ReportDetails)al[k];

                                if (detC.ChargeGroupName == chName)
                                {
                                    chAL.Add(detC);

                                    summ += detC.Summ;
                                }
                            }
                            AdvancedDataGridView.TreeGridNode node = tvdgCharges.Nodes.Add(det.ChargeGroupName, summ);

                            for (int x = 0; x < chAL.Count; x++)
                            {
                                DBLayer.AbonementIncome.Money_ReportDetails detCX = (DBLayer.AbonementIncome.Money_ReportDetails)chAL[x];

                                node.Nodes.Add(detCX.AbonementName, detCX.Summ);
                            }
                        }

                        break;
                }

                
            }

            slblTotal.Text = total.ToString();

            pnlAbonements.PanelTitle = "Абонементы: " + abonements.ToString();
            pnlBar.PanelTitle = "Бар: " + goods.ToString();
            pnlServices.PanelTitle = "Услуги: " + services.ToString();
            pnlCharges.PanelTitle = "Расходы: " + charges.ToString();
        }

        #endregion

        
        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enable to initialize Excel application references.| Line 384.");
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        void frm_SelectReasonMsg(object sender, FitnessProject.ServiceForms.ReasonEventArgs args)
        {
            DBLayer.AbonementIncome.Details det = DBLayer.AbonementIncome.GetDetails(this.Id);

            det.DeleteReason = args.Reason;

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
            
        }

        void frm3_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            DBLayer.AbonementIncome.Details det = DBLayer.AbonementIncome.GetDetails(this.Id);

            det.Date = args.SelectedDate;

            DBLayer.AbonementIncome.Update(det);

            LoadData();
        }

        private void CtrlIncomesOutcomes_Resize(object sender, EventArgs e)
        {
            tvdgAbonements.Width = pnlAbonements.Width;
            tvdgCharges.Width = pnlCharges.Width;
            tvdgGoods.Width = pnlBar.Width;
            tvdgServices.Width = pnlServices.Width;

            tvdgAbonements.Height = pnlAbonements.Height - 15;
            tvdgCharges.Height = pnlCharges.Height - 15;
            tvdgGoods.Height = pnlBar.Height - 15;
            tvdgServices.Height = pnlServices.Height - 15;
        }

        private void scFirst_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void scSecond_SplitterMoved(object sender, SplitterEventArgs e)
        {
            tvdgServices.Height = scFirst.Panel1.Height;
            tvdgCharges.Height = scSecond.Panel2.Height;
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            tvdgAbonements.Height = scFirst.Panel1.Height;
            tvdgGoods.Height = scFirst.Panel2.Height;

//            MessageBox.Show("!!!");
        }
    }
}
