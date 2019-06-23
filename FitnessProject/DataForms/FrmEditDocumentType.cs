using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.DataForms
{
    public partial class FrmEditDocumentType : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.DocumentType.Details Details = new FitnessProject.DBLayer.DocumentType.Details();

        #endregion

        public FrmEditDocumentType()
        {
            InitializeComponent();
        }

        public FrmEditDocumentType(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.DocumentType.GetDetails(id);

            tbName.Text = this.Details.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Name = tbName.Text;

            if (this.Id == 0)
            {
                DBLayer.DocumentType.Insert(this.Details);

                this.Close();
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.DocumentType.Update(this.Details);

                this.Close();
            }
        }
    }
}
