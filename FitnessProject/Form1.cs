using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DBLayer.Users.Details det = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            if (det.IsAdmin)
                tsAdmin.Visible = true;
            else
                tsAdmin.Visible = false;
        }

        #region FrameClear

        public void FrameClear()
        {
            if (Ctrl != null)
            {
                this.Ctrl.Dispose();
                this.Ctrl.Parent = null;
                this.Ctrl = null;
            }
        }

        #endregion

        #region Fields

        public UserControl Ctrl = new UserControl();

        #endregion

        private void источникиПривлеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAdvertisingSource ctrl = new FitnessProject.Components.CtrlAdvertisingSource();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void типыКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlClientType ctrl = new FitnessProject.Components.CtrlClientType();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void группыПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlProductGroup ctrl = new FitnessProject.Components.CtrlProductGroup();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlSuppliers ctrl = new FitnessProject.Components.CtrlSuppliers();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;            
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlDimension ctrl = new FitnessProject.Components.CtrlDimension();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void типыАбоненементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAbonements ctrl = new FitnessProject.Components.CtrlAbonements();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnCards_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlBarcodes ctrl = new FitnessProject.Components.CtrlBarcodes();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void ящикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlBoxes ctrl = new FitnessProject.Components.CtrlBoxes();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void типыДокументовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlDocumentType ctrl = new FitnessProject.Components.CtrlDocumentType();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnSuppliers_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlClient ctrlClient = new FitnessProject.Components.CtrlClient();
            ctrlClient.SelectClientMsg += new FitnessProject.Components.CtrlClient.SelectClientHandler(ctrlClient_SelectClientMsg);
            Ctrl = ctrlClient;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        void ctrlClient_SelectClientMsg(object sender, FitnessProject.DataForms.ClientSelectEventArgs args)
        {
            FrameClear();

            Components.CtrlVisit ctrl = new FitnessProject.Components.CtrlVisit(args.ClientId);
            ctrl.SelectClientMsg += new FitnessProject.Components.CtrlVisit.SelectClientHandler(ctrl_SelectClientMsg);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

       
        private void tbtnCharges_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlCharges ctrl = new FitnessProject.Components.CtrlCharges();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlGoods ctrl = new FitnessProject.Components.CtrlGoods();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlArrivals ctrl = new FitnessProject.Components.CtrlArrivals();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnUsers_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlUsers ctrl = new FitnessProject.Components.CtrlUsers();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void статьиРасходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlChargeGroup ctrl = new FitnessProject.Components.CtrlChargeGroup();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnServices_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlServices ctrl = new FitnessProject.Components.CtrlServices();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnVisits_Click(object sender, EventArgs e)
        {
            this.CoachId = 0;

            FrameClear();

            Components.CtrlVisit ctrl = new FitnessProject.Components.CtrlVisit();
            ctrl.SelectClientMsg += new FitnessProject.Components.CtrlVisit.SelectClientHandler(ctrl_SelectClientMsg);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        #region Fields

        public DBLayer.Clients.Details ClientDetails = new FitnessProject.DBLayer.Clients.Details();
        public int Number = 0;

        public int Type = 0;
        public DateTime Date = new DateTime();
        public bool WithoutKey = false;

        #endregion

        #region LoadBoxType

        public void LoadBoxType()
        {
            FrameClear();

            Components.CtrlBoxType ctrl = new FitnessProject.Components.CtrlBoxType(this.ClientDetails);
            ctrl.SelectTypeMsg += new FitnessProject.Components.CtrlBoxType.SelectTypeHandler(ctrl_SelectTypeMsg);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        void ctrl_SelectTypeMsg(object sender, FitnessProject.Components.TypeSelectEventArgs args)
        {
            if (args.Type == 1)
            {
                if (this.ClientDetails.Sex == 0)
                {
                    FrameClear();

                    Components.CtrlWomanSingle ctrlWS = new FitnessProject.Components.CtrlWomanSingle();
                    ctrlWS.SelectBoxMsg += new FitnessProject.Components.CtrlWomanSingle.SelectBoxHandler(ctrlWS_SelectBoxMsg);
                    Ctrl = ctrlWS;

                    Ctrl.Parent = pnlContainer;
                    Ctrl.Dock = DockStyle.Fill;
                }
                else
                {
                    FrameClear();

                    Components.CtrlManSingle ctrlMS = new FitnessProject.Components.CtrlManSingle();
                    ctrlMS.SelectBoxMsg += new FitnessProject.Components.CtrlManSingle.SelectBoxHandler(ctrlMS_SelectBoxMsg);
                    Ctrl = ctrlMS;

                    Ctrl.Parent = pnlContainer;
                    Ctrl.Dock = DockStyle.Fill;
                }
            }
            else
            {
                if (this.ClientDetails.Sex == 0)
                {
                    FrameClear();

                    Components.CtrlWomanDouble ctrlWD = new FitnessProject.Components.CtrlWomanDouble();
                    ctrlWD.SelectBoxMsg += new FitnessProject.Components.CtrlWomanDouble.SelectBoxHandler(ctrlWD_SelectBoxMsg);
                    Ctrl = ctrlWD;

                    Ctrl.Parent = pnlContainer;
                    Ctrl.Dock = DockStyle.Fill;
                }
                else
                {
                    FrameClear();

                    Components.CtrlManDouble ctrlMD = new FitnessProject.Components.CtrlManDouble();
                    ctrlMD.SelectBoxMsg += new FitnessProject.Components.CtrlManDouble.SelectBoxHandler(ctrlMD_SelectBoxMsg);
                    Ctrl = ctrlMD;

                    Ctrl.Parent = pnlContainer;
                    Ctrl.Dock = DockStyle.Fill;
                }
            }
        }

        void ctrlWD_SelectBoxMsg(object sender, FitnessProject.Components.BoxWomanSingleSelectEventArgs args)
        {
            this.Number = args.Number;

            this.Type = 3;

            LoadInfo();
        }

        void ctrlMD_SelectBoxMsg(object sender, FitnessProject.Components.BoxWomanSingleSelectEventArgs args)
        {
            this.Number = args.Number;

            this.Type = 4;

            LoadInfo();
        }

        void ctrlMS_SelectBoxMsg(object sender, FitnessProject.Components.BoxWomanSingleSelectEventArgs args)
        {
            this.Number = args.Number;

            this.Type = 2;

            LoadInfo();
        }

        void ctrlWS_SelectBoxMsg(object sender, FitnessProject.Components.BoxWomanSingleSelectEventArgs args)
        {
            this.Number = args.Number;

            this.Type = 1;

            LoadInfo();
        }

        #endregion

        void ctrl_SelectClientMsg(object sender, FitnessProject.Components.ClientSelectEventArgs args)
        {
            this.ClientDetails = DBLayer.Clients.GetDetails(args.Id);
            this.Date = args.Date;
            this.WithoutKey = args.WithoutKey;
            try
            {
                DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetClientLast(this.ClientDetails.Id);

                                
                
                if (!args.Exit)
                {
                    DBLayer.ClientsAbonements.Details caDet = DBLayer.ClientsAbonements.GetDetails(this.ClientDetails.Id, aDet.Id);

                    if (caDet.Id == 0)
                    {
                        var list = DBLayer.ClientsAbonements.GetList(this.ClientDetails.Id);

                        foreach (DBLayer.ClientsAbonements.ClientsAbonements_WideDetails det in list)
                        {
                            if ((DateTime.Now <= det.DateFinish) && (DateTime.Now >= det.DateStart))
                            {
                                caDet = DBLayer.ClientsAbonements.GetDetails(det.Id);
                            }
                        }
                    }

                    

                    if ((aDet.IsUnlim == false)) 
                    {
                        //if (caDet.VisitsCount >= 0)
                        //{
                            if (caDet.VisitsCount <= 0)
                            {
                                var list = DBLayer.ClientsAbonements.GetList(this.ClientDetails.Id);

                                //MessageBox.Show(list.Count.ToString());

                                bool val = false;

                                foreach (DBLayer.ClientsAbonements.ClientsAbonements_WideDetails det in list)
                                {
                                    //MessageBox.Show(det.Id.ToString() + " - " + det.VisitsCount.ToString());

                                    if ((det.VisitsCount > 0) && (det.DateFinish > DateTime.Now) && (det.Id != caDet.Id))
                                    {
                                        val = true;

                                        int id = det.Id;

                                        DBLayer.ClientsAbonements.Details caDet1 = DBLayer.ClientsAbonements.GetDetails(id);

                                        //MessageBox.Show(caDet1.VisitsCount.ToString());

                                        caDet1.VisitsCount = caDet1.VisitsCount - 1;

                                        DBLayer.ClientsAbonements.Update(caDet1);

                                        break;
                                    }
                                }

                                if (!val)
                                {
                                    MessageBox.Show(this, "Посещения закончились!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    //}

                    if (aDet.AbonementGroup == 1)
                    {
                        LoadCoaches();

                        
                    }
                    else
                        LoadBoxType();
                }
                else
                    LoadExitInfo();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Абонемент клиента истек или он его не приобретал!" + err.Message , Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region LoadInfo

        public void LoadInfo()
        {
            FrameClear();

            Components.CtrlInfo ctrl = new FitnessProject.Components.CtrlInfo(this.ClientDetails, this.Date, this.Number, this.Type, this.WithoutKey, this.CoachId);
            ctrl.FinishMsg += new FitnessProject.Components.CtrlInfo.FinishHandler(ctrl_FinishMsg);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        void ctrl_FinishMsg(object sender, FitnessProject.Components.FinishEventArgs args)
        {
            FrameClear();

            Components.CtrlVisit ctrl = new FitnessProject.Components.CtrlVisit();
            ctrl.SelectClientMsg += ctrl_SelectClientMsg;
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;

        }

        #endregion

        public int CoachId = 0;

        #region LoadCoaches

        private void LoadCoaches()
        {
            FrameClear();

            Components.CtrlCoachesOnVisit ctrl = new FitnessProject.Components.CtrlCoachesOnVisit(this.ClientDetails.Id);
            ctrl.SelectCoachMsg += new FitnessProject.Components.CtrlCoachesOnVisit.SelectCoachHandler(ctrl_SelectCoachMsg);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        void ctrl_SelectCoachMsg(object sender, FitnessProject.Components.CoachSelectEventArgs args)
        {
            this.CoachId = args.Id;

            //MessageBox.Show(CoachId.ToString());

            LoadBoxType();
        }

        #endregion

        #region LoadExitInfo

        public void LoadExitInfo()
        {
            FrameClear();

            Components.CtrlExitInfo ctrl1 = new FitnessProject.Components.CtrlExitInfo(this.ClientDetails);
            ctrl1.FinishMsg += new FitnessProject.Components.CtrlExitInfo.FinishHandler(ctrl1_FinishMsg);
            Ctrl = ctrl1;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        void ctrl1_FinishMsg(object sender, FitnessProject.Components.FinishEventArgs args)
        {
            FrameClear();

            Components.CtrlVisit ctrl = new FitnessProject.Components.CtrlVisit();
            ctrl.SelectClientMsg += ctrl_SelectClientMsg;
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        #endregion

        private void tbtnSales_Click(object sender, EventArgs e)
        {
            DataForms.FrmSale frm = new FitnessProject.DataForms.FrmSale();
            frm.ShowDialog();

            MessageBox.Show("Подтвердите продажу товара!");

            //FrameClear();

            //Components.SalesInterface ctrl = new FitnessProject.Components.SalesInterface();
            //Ctrl = ctrl;

            //Ctrl.Parent = pnlContainer;
            //Ctrl.Dock = DockStyle.Fill;
        }

        private void тренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlCoaches ctrl = new FitnessProject.Components.CtrlCoaches();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void клиентыВЗалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlClientsOnline ctrl = new FitnessProject.Components.CtrlClientsOnline();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void посещенияЗалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlVisits ctrl = new FitnessProject.Components.CtrlVisits();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void продажиАбонементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAbonementSale ctrl = new FitnessProject.Components.CtrlAbonementSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnServiceSale_Click(object sender, EventArgs e)
        {
            DataForms.FrmServiceSale frm = new FitnessProject.DataForms.FrmServiceSale();
            frm.ShowDialog();

            MessageBox.Show("Подтвердите продажу услуги!");
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlServiceSale ctrl = new FitnessProject.Components.CtrlServiceSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void продажиТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlGoodSale ctrl = new FitnessProject.Components.CtrlGoodSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void движениеДенежныхСредствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlMoneyMovement ctrl = new FitnessProject.Components.CtrlMoneyMovement();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void отказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlDeclines ctrl = new FitnessProject.Components.CtrlDeclines();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnExit_Click(object sender, EventArgs e)
        {
            DBLayer.Users.Details User = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            int id = DBLayer.UserVisits.GetLastVisit(User.Id);

            DBLayer.UserVisits.SetTimeOff(id, DateTime.Now.ToShortTimeString());

            AppDomain.CurrentDomain.SetData("User", null);

            Application.Exit();
        }

        private void графикСменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlUserVisits ctrl = new FitnessProject.Components.CtrlUserVisits();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void администраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAdministrators ctrl = new FitnessProject.Components.CtrlAdministrators();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnPrepaid_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmPrePaid frm = new FitnessProject.ServiceForms.FrmPrePaid();
            frm.ShowDialog();
        }

        private void доходыСменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlUserIncome ctrl = new FitnessProject.Components.CtrlUserIncome();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void остаткиТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlRests ctrl = new FitnessProject.Components.CtrlRests();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlIncomesOutcomes ctrl = new FitnessProject.Components.CtrlIncomesOutcomes();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAbonementSale ctrl = new FitnessProject.Components.CtrlAbonementSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlServiceSale ctrl = new FitnessProject.Components.CtrlServiceSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlGoodSale ctrl = new FitnessProject.Components.CtrlGoodSale();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void tbtnAdditionalVisits_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAdditionalVisits ctrl = new FitnessProject.Components.CtrlAdditionalVisits();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void дниРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlBirthdays ctrl = new FitnessProject.Components.CtrlBirthdays();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void посещенияКТренерамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlCoachesVisits ctrl = new FitnessProject.Components.CtrlCoachesVisits();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void дниРожденияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlBirthdays ctrl = new FitnessProject.Components.CtrlBirthdays();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void продажиАбонементовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlAbonementSale ctrl = new FitnessProject.Components.CtrlAbonementSale(true);
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void кассаToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrameClear();

            Components.CtrlMoneyMovement ctrl = new Components.CtrlMoneyMovement();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

        private void графикФинансовойАктивностиПоДнямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameClear();

            Components.CtrlChart ctrl = new Components.CtrlChart();
            Ctrl = ctrl;

            Ctrl.Parent = pnlContainer;
            Ctrl.Dock = DockStyle.Fill;
        }

    }
}
