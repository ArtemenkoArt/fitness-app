using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace FitnessProject.Components
{
    public partial class CtrlVisit : UserControl
    {
        #region Fields

        public DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();
        public bool WithoutKey = false;

        public bool ForExit = false;

        #endregion

        public CtrlVisit()
        {
            InitializeComponent();

            btnView.Enabled = false;
            gridControl1.Enabled = false;
            tbFIO.Enabled = false;
            cbLeave.Enabled = false;

            tbBarcode.Focus();
        }

        public CtrlVisit(int id)
        {
            InitializeComponent();

            tbBarcode.Focus();

            this.Details = DBLayer.Clients.GetDetails(id);

            tbBarcode.Text = this.Details.Barcode;

            btnView.Enabled = false;
            gridControl1.Enabled = false;
            tbFIO.Enabled = false;
            cbLeave.Enabled = false;
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {                     
            if (e.KeyCode == Keys.Enter)
            {
                string code = tbBarcode.Text;

                this.Details = DBLayer.Clients.GetDetails(code);
                this.WithoutKey = false;

                ArrayList al = DBLayer.Clients.GetOnlineList();

                for (int i = 0; i < al.Count; i++)
                {
                    string codeOnline = ((DBLayer.Clients.Clients_WideDetails)al[i]).Barcode;

                    //MessageBox.Show(codeOnline);

                    if (tbBarcode.Text == codeOnline)
                    {
                        //MessageBox.Show("Yes");
                        this.ForExit = true;
                        break;
                    }
                }

                SimulateSelectClient();
            }
        }

        #region Client Select Event

        public delegate void SelectClientHandler(object sender, ClientSelectEventArgs args);

        public event SelectClientHandler SelectClientMsg;

        protected virtual void OnSelectClient(ClientSelectEventArgs e)
        {
            if (SelectClientMsg != null)
            {
                SelectClientMsg(this, e);
            }
        }

        public void SimulateSelectClient()
        {
            ClientSelectEventArgs e = new ClientSelectEventArgs(this.Details.Id, this.WithoutKey, this.ForExit);

            OnSelectClient(e);            
        }

        #endregion

        #region LoadData

        private void LoadData(string name)
        {
            ArrayList al = new ArrayList();

            if (!this.ForExit)
            {
                if (name == "")
                {
                    al = DBLayer.Clients.GetListForInput();
                }
                else
                {
                    al = DBLayer.Clients.GetListForInputByName(name);
                }
            }
            else
            {
                if (name == "")
                {
                    al = DBLayer.Visits.GetListOnline();
                }
                else
                {
                    al = DBLayer.Clients.GetListByName(name);
                }
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("FIO");

            for (int i = 0; i < al.Count; i++)
            {               
                DataRow dr = dt.Rows.Add();

                if (!ForExit)
                {
                    DBLayer.Clients.Clients_WideDetails det = (DBLayer.Clients.Clients_WideDetails)al[i];

                    dr["Id"] = det.Id;
                    dr["FIO"] = det.FIO;
                }
                else
                {
                    if (al[i] is DBLayer.Visits.Visits_WideDetails)
                    {
                        DBLayer.Visits.Visits_WideDetails detV = (DBLayer.Visits.Visits_WideDetails)al[i];

                        dr["Id"] = detV.ClientId;
                        dr["FIO"] = detV.ClientName;
                    }
                    else if (al[i] is DBLayer.Clients.Clients_WideDetails)
                    {
                        DBLayer.Clients.Clients_WideDetails detc = (DBLayer.Clients.Clients_WideDetails)al[i];

                        dr["Id"] = detc.Id;
                        dr["FIO"] = detc.FIO;

                    }
                }
                
            }

            gridControl1.DataSource = dt;

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void cbWithout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWithout.Checked)
            {
                btnView.Enabled = true;
                gridControl1.Enabled = true;
                tbFIO.Enabled = true;
                cbLeave.Enabled = true;

                LoadData("");
            }
            else
            {
                btnView.Enabled = false;
                gridControl1.Enabled = false;
                tbFIO.Enabled = false;
                cbLeave.Enabled = false;
            }
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbFIO.Text);
        }

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
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

            this.Details = DBLayer.Clients.GetDetails(ind);

            ServiceForms.FrmViewClient frm = new FitnessProject.ServiceForms.FrmViewClient(DBLayer.Clients.GetDetails(ind));
            frm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbWithout.Checked)
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

                this.WithoutKey = true;
                this.Details = DBLayer.Clients.GetDetails(ind);

                //MessageBox.Show(this.Details.FIO);

                SimulateSelectClient();
            }
            else
            {
                string code = tbBarcode.Text;

                try
                {
                    try
                    {
                        this.Details = DBLayer.Clients.GetDetails(code);
                    }
                    catch
                    {
                        code = Lib.ServiceFunctions.ScanPrefix() + code;

                        this.Details = DBLayer.Clients.GetDetails(code);
                    }
                    this.WithoutKey = false;

                    ArrayList al = DBLayer.Clients.GetOnlineList();

                    for (int i = 0; i < al.Count; i++)
                    {
                        string codeOnline = ((DBLayer.Clients.Clients_WideDetails)al[i]).Barcode;

                        //MessageBox.Show(codeOnline);

                        if (Lib.ServiceFunctions.ScanPrefix() + tbBarcode.Text == codeOnline)
                        {
                            //MessageBox.Show("Yes");
                            this.ForExit = true;
                            break;
                        }
                    }

                    SimulateSelectClient();
                }
                catch (Exception err)
                {
                    MessageBox.Show("На данную карту не заведен клиент!" + err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLeave.Checked)
                this.ForExit = true;
            else
                this.ForExit = false;

            LoadData("");
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditClient frm = new FitnessProject.DataForms.FrmEditClient();
            frm.ShowDialog();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditClient frm = new FitnessProject.DataForms.FrmEditClient(true);
            frm.ShowDialog();
        }

        private void gbWithoutCard_Enter(object sender, EventArgs e)
        {

        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {

        }
    }

    #region ClientSelectEventArgs Class

    public class ClientSelectEventArgs : EventArgs
    {
        #region Constructor

        public ClientSelectEventArgs(int id, bool key, bool exit)
        {
            this.Id = id;
            this.Date = DateTime.Now;
            this.WithoutKey = key;
            this.Exit = exit;
        }

        #endregion

        #region Fields

        public readonly int Id;
        public readonly DateTime Date = new DateTime();
        public bool WithoutKey = false;
        public bool Exit = false;

        #endregion
    }

    #endregion
}
