using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditSupplier : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Suppliers.Details Details = new FitnessProject.DBLayer.Suppliers.Details();

        #endregion

        public FrmEditSupplier()
        {
            InitializeComponent();
        }

        public FrmEditSupplier(int id)
        {
            InitializeComponent();

            this.Id = id;

            //MessageBox.Show(this.Id.ToString());

            this.Details = DBLayer.Suppliers.GetDetails(id);

            tbName.Text = this.Details.Name;
            tbDirector.Text = this.Details.Director;
            tbFax.Text = this.Details.Fax;
            tbPhone.Text = this.Details.Phone;

            ddlType.SelectedIndex = this.Details.Type;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validation

        public bool Validation()
        {
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show(this, "Не указано название поставщика!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                this.Details.Director = tbDirector.Text;
                this.Details.Fax = tbFax.Text;
                this.Details.Name = tbName.Text;
                this.Details.Phone = tbPhone.Text;

                this.Details.Type = ddlType.SelectedIndex;

                if (this.Id == 0)
                {
                    DBLayer.Suppliers.Insert(this.Details);
                }
                else
                {
                    //his.Details.Id = this.Id;

                    //MessageBox.Show(this.Details.Id.ToString());

                    DBLayer.Suppliers.Update(this.Details);
                }

                this.Close();
            }
        }
    }
}
