using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FitnessProject.ServiceForms
{
    public partial class FrmSelectAbonement : Form
    {
        public FrmSelectAbonement()
        {
            InitializeComponent();

            LoadAbonements();
        }

        private void LoadAbonements(string name = "")
        {
            lvAbonements.Items.Clear();

            var al = DBLayer.Abonements.GetList();

            if (!string.IsNullOrEmpty(name))
            {
                al = al.Where(a => a.Name.ToLower().Contains(name.ToLower())).ToList();
            }

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Abonements.WideDetails det = (DBLayer.Abonements.WideDetails)al[i];

                ListViewItem li = new ListViewItem();

                li.Tag = det.Id;
                li.Text = det.Name;

                if (rbFitness.Checked)
                {
                    if (det.AbonementGroup == 0)
                    {
                        lvAbonements.Items.Add(li);
                    }
                }
                else
                {
                    if (det.AbonementGroup == 1)
                    {
                        lvAbonements.Items.Add(li);
                    }
                }
            }
        }

        #region SelectAbonementEventArgs Class

        public class SelectAbonementEventArgs : EventArgs
        {
            #region Constructor

            public SelectAbonementEventArgs(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            #endregion

            #region Fields

            public readonly int Id = 0;
            public readonly string Name = "";

            #endregion
        }

        #endregion

        #region Select Abonement Event

        public delegate void SelectAbonementEventHandler(object sender, SelectAbonementEventArgs args);

        public event SelectAbonementEventHandler SelectAbonementMsg;

        protected virtual void OnSelectAbonement(SelectAbonementEventArgs e)
        {
            if (SelectAbonementMsg != null)
            {
                SelectAbonementMsg(this, e);
            }
        }

        public void SimulateSelectAbonement()
        {
            var lv = lvAbonements.SelectedItems[0];

            SelectAbonementEventArgs e = new SelectAbonementEventArgs
                (Convert.ToInt32(lv.Tag), lv.Text);

            OnSelectAbonement(e);

            this.Close();
        }

        #endregion

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            LoadAbonements(tbName.Text);
        }

        private void rbAero_CheckedChanged(object sender, EventArgs e)
        {
            LoadAbonements(tbName.Text);
        }

        private void rbFitness_CheckedChanged(object sender, EventArgs e)
        {
            LoadAbonements(tbName.Text);
        }

        private void lvAbonements_DoubleClick(object sender, EventArgs e)
        {
            if (lvAbonements.SelectedItems.Count > 0)
            {
                SimulateSelectAbonement();
            }
        }
    }
}
