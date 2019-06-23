using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.Components
{
    public partial class CtrlBoxes : UserControl
    {
        public CtrlBoxes()
        {
            InitializeComponent();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditBox frm = new FitnessProject.DataForms.FrmEditBox();
            frm.ShowDialog();
        }

        private void tbtnEdit_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditBox frm = new FitnessProject.DataForms.FrmEditBox();
            frm.ShowDialog();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить ящик?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
        }

        private void tbtnVisualization_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmWindowsVisualization frm = new FitnessProject.ServiceForms.FrmWindowsVisualization();
            frm.ShowDialog();
        }
    }
}
