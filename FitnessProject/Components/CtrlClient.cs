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
    public partial class CtrlClient : UserControl
    {
        #region Fields

        public int Id = 0;
        ArrayList AL = new ArrayList();

        #endregion

        public CtrlClient()
        {
            InitializeComponent();

            LoadData();

            DBLayer.Users.Details det = (DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User");

            if (det.IsAdmin)
                tbtnRemove.Visible = true;
            else
                tbtnRemove.Visible = false;

            advBandedGridView1.ColumnFilterChanged += new EventHandler(advBandedGridView1_ColumnFilterChanged);
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = new ArrayList();

            if (tbName.Text.Trim() == "")
            {
                if (tbBarcode.Text.Trim() == "")
                    al = DBLayer.Clients.GetList();
                else
                    al = DBLayer.Clients.GetListByBarcode(tbBarcode.Text);
            }
            else
            {
                al = DBLayer.Clients.GetListByName(tbName.Text);
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("ClientType");
            dt.Columns.Add("DocumentType");
            dt.Columns.Add("Source");
            dt.Columns.Add("VisitsStatus");
            dt.Columns.Add("FIO");
            dt.Columns.Add("Card");
            dt.Columns.Add("RegisterDate", typeof(DateTime));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("VisitsCount", typeof(int));
            dt.Columns.Add("AbonementsVisitsCount", typeof(int));
            dt.Columns.Add("Phone");
            dt.Columns.Add("Sex");
            dt.Columns.Add("AbonementName");
            dt.Columns.Add("FinishDate", typeof(DateTime));
            dt.Columns.Add("Type");
            dt.Columns.Add("Coach");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Clients.Clients_WideDetails det = (DBLayer.Clients.Clients_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                if (det.AVisitsCount > 0)
                {
                    dr["AbonementsVisitsCount"] = det.AVisitsCount;
                }

                dr["Card"] = det.Barcode;
                dr["Id"] = det.Id;

                dr["ClientType"] = det.TypeName;
                dr["Coach"] = det.CoachName;
                dr["DocumentType"] = det.DocumentName;
                dr["Source"] = det.SourceName;

                dr["FIO"] = det.FIO;
                dr["RegisterDate"] = det.RegisterDate;
                dr["Phone"] = det.Phone;

                string visitsStatus = string.Empty;

                int vC = det.AVisitsCount - det.VisitsCount;

                if (det.AVisitsCount > 0)
                {
                    if (det.VisitsCount == 0)
                    {
                        visitsStatus = "Посещения закончились";
                    }

                    if (det.VisitsCount < 0)
                    {
                        visitsStatus = string.Empty;
                    }

                    if (det.VisitsCount == 1)
                    {
                        visitsStatus = "Последнее посещение";
                    }

                    if (vC > 1)
                    {
                        visitsStatus = string.Empty;
                    }

                }

                dr["VisitsStatus"] = visitsStatus;
                
                if (det.Sex == 0)
                {
                    dr["Sex"] = "Женщина";
                }
                else
                {
                    dr["Sex"] = "Мужчина";
                }

                dr["FinishDate"] = det.FinishDate;
                dr["AbonementName"] = det.AbonementName;

                if (det.VisitsCount > 0)
                {
                    dr["VisitsCount"] = det.VisitsCount;
                }

                string type = "";

                if (((DateTime.Now - det.FinishDate).Days > -7) && ((DateTime.Now - det.FinishDate).Days < 0))
                    type = "Скоро заканчивается";
                else if ((DateTime.Now - det.FinishDate).Days >= 0)
                    type = "Просрочен";
                else
                    type = "Текущий";

                dr["Type"] = type;
            }

            grClients.DataSource = dt;

            advBandedGridView1.BestFitColumns();

            try
            {
                slblTotal.Text = advBandedGridView1.RowCount.ToString();
            }
            catch { }
        }

        #endregion

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditClient frm = new FitnessProject.DataForms.FrmEditClient();
            frm.SelectClientMsg += new FitnessProject.DataForms.FrmEditClient.SelectClientHandler(frm_SelectClientMsg);
            frm.ShowDialog();

            LoadData();
        }

        void frm_SelectClientMsg(object sender, FitnessProject.DataForms.ClientSelectEventArgs args)
        {
            try
            {
                this.Id = args.ClientId;

                SimulateSelectClient();
            }
            catch { }
        }

        #region Client Select Event

        public delegate void SelectClientHandler(object sender, DataForms.ClientSelectEventArgs args);

        public event SelectClientHandler SelectClientMsg;

        protected virtual void OnSelectClient(DataForms.ClientSelectEventArgs e)
        {
            if (SelectClientMsg != null)
            {
                SelectClientMsg(this, e);
            }
        }

        public void SimulateSelectClient()
        {
            DataForms.ClientSelectEventArgs e = new DataForms.ClientSelectEventArgs(this.Id);

            OnSelectClient(e);
        }

        #endregion

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

            DataForms.FrmEditClient frm = new FitnessProject.DataForms.FrmEditClient(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить клиента?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.Clients.Delete(ind);

                LoadData();
            }
        }

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                //advBandedGridView1.ExportToExcel(sfdExcel.FileName);
            }
        }

        private void advBandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            slblTotal.Text = advBandedGridView1.RowCount.ToString();

            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

            ServiceForms.ViewReport frm = new FitnessProject.ServiceForms.ViewReport(ind);
            frm.ShowDialog();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            tbBarcode.Text = "";

            LoadData();
        }

        private void tbName_Click(object sender, EventArgs e)
        {

        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbName.Text = "";

                LoadData();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                tbBarcode.Text = "";

                LoadData();
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tbName.Text = "";

                LoadData();
            }
        }

        private void advBandedGridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //System.Data.DataRowView DR = (System.Data.DataRowView)(this.advBandedGridView1.GetRow(e.RowHandle));

            //DateTime finishDate = Convert.ToDateTime(DR["FinishDate"]);

            //if ((DateTime.Now - finishDate.Date).Days > -7)
            //    e.Appearance.BackColor = Color.Orange;

            //if ((DateTime.Now.Date - finishDate.Date).Days >= 0)
            //{
            //    e.Appearance.BackColor = Color.Coral;                

            //    if (DateTime.Now < finishDate)
            //    {
            //        //MessageBox.Show(finishDate.Date.ToString() + " " + DateTime.Now.ToString());

            //        TimeSpan ts = DateTime.Now - finishDate;

            //        int days = (DateTime.Now - finishDate).Days;

            //        //MessageBox.Show(days.ToString());
            //    }
            //}
        }

        private void ddlClients_Click(object sender, EventArgs e)
        {

        }

        private void CtrlClient_Load(object sender, EventArgs e)
        {

        }

        private void tbtnAbonements_Click(object sender, EventArgs e)
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

            DataForms.FrmAbonements frm = new FitnessProject.DataForms.FrmAbonements(ind);
            frm.ShowDialog();
        }
    }
}


