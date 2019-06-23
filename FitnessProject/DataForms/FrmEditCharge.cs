using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.DataForms
{
    public partial class FrmEditCharge : Form
    {
        #region Fields

        private int Id = 0;
        private DBLayer.Charges.Details Details = new FitnessProject.DBLayer.Charges.Details();

        #endregion

        public FrmEditCharge()
        {
            InitializeComponent();

            LoadList(0);
        }

        public FrmEditCharge(int id)
        {
            InitializeComponent();

            this.Id = id;
            this.Details = DBLayer.Charges.GetDetails(id);

            tbDate.Text = this.Details.Date.ToString("dd-MMM-yyyy");
            tbName.Text = this.Details.Name;
            tbSumm.Text = this.Details.Summ.ToString();

            //MessageBox.Show(this.Details.GroupId.ToString());

            LoadList(this.Details.GroupId);
        }

        #region LoadList

        private void LoadList(int id)
        {
            ArrayList al = DBLayer.ChargeGroup.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.ChargeGroup.Details det = (DBLayer.ChargeGroup.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbChargesGroup.Items.Add(li);
            }

            if (id != 0)
            {
                for (int i = 0; i < cbChargesGroup.Items.Count; i++)
                {
                    Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbChargesGroup.Items[i];

                    if (li.ID == id)
                    {
                        cbChargesGroup.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Date = Convert.ToDateTime(tbDate.Text);
            this.Details.Summ = Convert.ToDouble(tbSumm.Text);
            this.Details.Name = tbName.Text;
            this.Details.GroupId = ((Lib.ServiceFunctions.ListItem)cbChargesGroup.SelectedItem).ID;

            if (this.Id == 0)
            {
                DBLayer.Charges.Insert(this.Details);
            }
            else
            {
                DBLayer.Charges.Update(this.Details);
            }

            this.Close();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frm = new FitnessProject.ServiceForms.FrmCalendar();
            frm.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frm_SelectDateMsg);
            frm.ShowDialog();
        }

        void frm_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
        }
    }
}
