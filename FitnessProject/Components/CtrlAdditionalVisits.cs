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
    public partial class CtrlAdditionalVisits : UserControl
    {
        public DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();
        public bool WithoutKey = false;

        public bool ForExit = false;

        #region LoadClient

        private void LoadClient()
        {
            if (this.Details.Id != 0)
            {
                lblMyVisits.Visible = true;
                lblMyVisitsCount.Visible = true;
                lblVisitsCount.Visible = true;
                lblVisitsLabel.Visible = true;
                btnVisit.Visible = true;

                lblClient.Text = this.Details.FIO;

                DBLayer.Abonements.Details aDet = DBLayer.Clients.GetCurrentAbonement(this.Details.Id);
                if (aDet.Id != 0)
                {
                    lblAbonement.Text = aDet.Name;

                    if (aDet.AdditionalVisits > 0)
                    {
                        lblVisitsCount.Text = aDet.AdditionalVisits.ToString();

                        DBLayer.ClientsAbonements.Details caDet = DBLayer.ClientsAbonements.GetDetails(this.Details.Id, aDet.Id);

                        lblMyVisits.Text = caDet.AdditionalCount.ToString();

                        if (caDet.AdditionalCount > 0)
                        {
                            this.CADetails = caDet;
                            btnVisit.Enabled = true;
                        }
                        else
                        {
                            btnVisit.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данный абонемент не предусматривает дополнительных посещений!");
                    }
                }
            }
        }

        #endregion

        public CtrlAdditionalVisits()
        {
            InitializeComponent();

            lblMyVisits.Visible = false;
            lblMyVisitsCount.Visible = false;
            lblVisitsCount.Visible = false;
            lblVisitsLabel.Visible = false;

            btnView.Enabled = false;
            gridControl1.Enabled = false;
            tbFIO.Enabled = false;
            cbLeave.Enabled = false;

            tbBarcode.Focus();
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

                LoadClient();

            }
            else
            {
                string code = Lib.ServiceFunctions.ScanPrefix() + tbBarcode.Text;

                this.Details = DBLayer.Clients.GetDetails(code);

                LoadClient();
            }
        }

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
                    DBLayer.Visits.Visits_WideDetails detV = (DBLayer.Visits.Visits_WideDetails)al[i];

                    dr["Id"] = detV.ClientId;
                    dr["FIO"] = detV.ClientName;
                }

            }

            gridControl1.DataSource = dt;

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        DBLayer.ClientsAbonements.Details CADetails = new FitnessProject.DBLayer.ClientsAbonements.Details();

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

        private void cbLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLeave.Checked)
                this.ForExit = true;
            else
                this.ForExit = false;

            LoadData("");
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

        private void btnVisit_Click(object sender, EventArgs e)
        {
            if (CADetails.Id != 0)
            {
                CADetails.AdditionalCount = CADetails.AdditionalCount - 1;

                DBLayer.ClientsAbonements.Update(this.CADetails);

                MessageBox.Show("Визит сохранен!");
            }
            else
            {
                MessageBox.Show("Невозможно сохранить визит!");
            }
        }
    }
}
