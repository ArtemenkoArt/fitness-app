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
    public partial class FrmEditAbonement : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Abonements.Details Details = new FitnessProject.DBLayer.Abonements.Details();

        #endregion

        public FrmEditAbonement()
        {
            InitializeComponent();

            LoadCoaches(0);

            tbcMain.TabPages.RemoveAt(1);
        }

        public FrmEditAbonement(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Abonements.GetDetails(id);

            LoadCoaches(this.Details.CoachId);

            tbName.Text = this.Details.Name;

            tbLength.Text = this.Details.Length.ToString();

            tbTotalCost.Text = (this.Details.Cost).ToString();

            tbLessonsCount.Text = this.Details.LessonsCount.ToString();

            ddlAbonementType.SelectedIndex = this.Details.AbonementGroup;

            cbSingle.Checked = this.Details.IsSingle;

            tbTime.Text = this.Details.Time;

            cbUnlim.Checked = this.Details.IsUnlim;

            tbWeekdays.Text = this.Details.Weekdays;

            tbAdditionalVisits.Text = this.Details.AdditionalVisits.ToString();

            LoadData();
        }

        #region LoadAbonements

        private void LoadCoaches(int id)
        {
            cbCoach.Items.Clear();

            ArrayList al = DBLayer.Coaches.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Coaches.Details det = (DBLayer.Coaches.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbCoach.Items.Add(li);
            }

            for (int i = 0; i < cbCoach.Items.Count; i++)
            {
                Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbCoach.Items[i];

                if (li.ID == id)
                {
                    cbCoach.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.AbonementPriceDynamic.GetList(this.Id);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("DateStart", typeof(DateTime));
            dt.Columns.Add("DateFinish", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AbonementPriceDynamic.Details det = (DBLayer.AbonementPriceDynamic.Details)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["Price"] = det.Price;

                dr["DateStart"] = det.DateStart;
                dr["DateFinish"] = det.DateFinish;
            }

            grPrices.DataSource = dt;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.Name = tbName.Text;
            this.Details.Cost = Convert.ToDouble(tbTotalCost.Text);

            this.Details.Length = Convert.ToDouble(tbLength.Text);
            this.Details.AbonementGroup = ddlAbonementType.SelectedIndex;
            this.Details.LessonsCount = Convert.ToInt32(tbLessonsCount.Text);
            this.Details.IsSingle = cbSingle.Checked;
            this.Details.IsUnlim = cbUnlim.Checked;
            this.Details.Time = tbTime.Text;
            this.Details.Weekdays = tbWeekdays.Text;
            this.Details.AdditionalVisits = Convert.ToInt32(tbAdditionalVisits.Text);

            if ((cbCoach.Enabled) && (cbCoach.SelectedItem != null))
            {
                this.Details.CoachId = ((Lib.ServiceFunctions.ListItem)cbCoach.SelectedItem).ID;
            }
            else
            {
                this.Details.CoachId = 0;
            }

            if (this.Id == 0)
            {
                int id = DBLayer.Abonements.Insert(this.Details);

                DBLayer.AbonementPriceDynamic.Details aDet = new FitnessProject.DBLayer.AbonementPriceDynamic.Details();

                aDet.AbonementId = id;
                aDet.DateStart = DateTime.Now;
                aDet.DateFinish = DateTime.Now.AddYears(1);
                aDet.Price = Convert.ToDouble(tbTotalCost.Text);

                DBLayer.AbonementPriceDynamic.Insert(aDet);
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.Abonements.Update(this.Details);
            }

            this.Close();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmEditAbonementPrice frm = new FrmEditAbonementPrice(DBLayer.Abonements.GetDetails(this.Id));
            frm.ShowDialog();

            LoadData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить прайс?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                DBLayer.AbonementPriceDynamic.Delete(ind);

                LoadData();
            }
        }

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


            DataForms.FrmEditAbonementPrice frm = new FrmEditAbonementPrice(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void cbUnlim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnlim.Checked)
            {
                tbTime.Enabled = false;
                cbCoach.Enabled = false;
                tbLessonsCount.Text = "0";
                tbLessonsCount.Enabled = false;
                tbWeekdays.Enabled = false;

                cbSingle.Enabled = false;
            }
            else
            {
                tbTime.Enabled = true;
                cbCoach.Enabled = true;
                tbLessonsCount.Enabled = true;
                cbSingle.Enabled = true;
                tbWeekdays.Enabled = true;
            }
        }

        private void cbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSingle.Checked)
            {
                cbUnlim.Enabled = false;

                cbCoach.Enabled = true;
                tbLessonsCount.Enabled = false;
                tbLessonsCount.Text = "1";
                tbLength.Enabled = false;
            }
            else
            {
                cbCoach.Enabled = true;
                tbLessonsCount.Enabled = true;
                tbLessonsCount.Text = "0";
                tbLength.Enabled = true;

                cbUnlim.Enabled = true;
            }
        }
    }
}
