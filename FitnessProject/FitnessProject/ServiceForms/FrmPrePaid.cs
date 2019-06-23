using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.ServiceForms
{
    public partial class FrmPrePaid : Form
    {
        public FrmPrePaid()
        {
            InitializeComponent();

            LoadList();
        }

        #region LoadList

        private void LoadList()
        {
            DBLayer.Users.Details detU = (DBLayer.Users.Details) AppDomain.CurrentDomain.GetData("User");

            ArrayList al = DBLayer.Administrators.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Administrators.Details det = (DBLayer.Administrators.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.FIO;

                ddlAdministrators.Items.Add(li);
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBLayer.Charges.Details det = new FitnessProject.DBLayer.Charges.Details();

            //det.AdminstratorId = ((Lib.ServiceFunctions.ListItem)ddlAdministrators.SelectedItem).ID;
            det.Date = DateTime.Now.Date;
            det.GroupId = 3;

            string name = "";

            if (!this.IsChanged)
            {
                name = ((Lib.ServiceFunctions.ListItem)ddlAdministrators.SelectedItem).Name;
            }
            else
            {
                name = ddlAdministrators.Text;
            }

            det.Name = "Аванс: " + name;
            det.Summ = Convert.ToDouble(tbSumm.Text);

            DBLayer.Charges.Insert(det);

            this.Close();

        }

        bool IsChanged = false;

        private void ddlAdministrators_KeyDown(object sender, KeyEventArgs e)
        {
            IsChanged = true;
        }
    }
}
