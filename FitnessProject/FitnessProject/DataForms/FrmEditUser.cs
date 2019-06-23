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
    public partial class FrmEditUser : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Users.Details Details = new FitnessProject.DBLayer.Users.Details();
        DBLayer.UserRate.Details urDet = new FitnessProject.DBLayer.UserRate.Details();

        #endregion

        public FrmEditUser()
        {
            InitializeComponent();
        }

        public FrmEditUser(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Users.GetDetails(id);

            tbCode.Text = this.Details.Barcode;
            tbFIO.Text = this.Details.FIO;
            tbJobTitle.Text = this.Details.JobTitle;

            cbIsAdmin.Checked = this.Details.IsAdmin;

            tbLogin.Text = this.Details.Login;
            tbPassword.Text = this.Details.Password;

            try
            {
                urDet = DBLayer.UserRate.GetDetails(this.Id);
            }
            catch { }

            tbBar.Text = urDet.PercentForSales.ToString();
            tbServices.Text = urDet.PercentForService.ToString();
            tbAbonements.Text = urDet.PercentForClients.ToString();
            tbConstant.Text = urDet.Constant.ToString();
            tbFitness.Text = urDet.PercentForFitness.ToString();
            tbMassage.Text = urDet.PercentForMassage.ToString();

            LoadData();
            LoadAdminsData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.UserVisits.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("User");
            dt.Columns.Add("TimeOn");
            dt.Columns.Add("TimeOff");

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.UserVisits.UserVisits_WideDetails det = (DBLayer.UserVisits.UserVisits_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Date"] = det.Date;
                dr["User"] = det.UserFIO;
                dr["TimeOn"] = det.TimeOn;
                dr["TimeOff"] = det.TimeOff;
            }

            grVisits.DataSource = dt;
            advBandedGridView1.BestFitColumns();
        }

        #endregion

        #region LoadAdminsData

        private void LoadAdminsData()
        {
            ArrayList al = DBLayer.UserAdministrator.GetList(this.Id);

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("FIO");         

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.UserAdministrator.UserAdministrator_WideDetails det = (DBLayer.UserAdministrator.UserAdministrator_WideDetails)al[i];

                DataRow dr = dt.Rows.Add();

                dr["Id"] = det.Id;
                dr["FIO"] = det.AdministratorName;
                
            }

            grAdmins.DataSource = dt;
            advBandedGridView2.BestFitColumns();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Details.FIO = tbFIO.Text;

            this.Details.Login = tbLogin.Text;

            this.Details.Password = tbPassword.Text;

            this.Details.JobTitle = tbJobTitle.Text;

            this.Details.Barcode = tbCode.Text;

            this.Details.IsAdmin = cbIsAdmin.Checked;

            if (this.Id == 0)
            {
                DBLayer.Users.Insert(this.Details);

                this.Close();
            }
            else
            {
                this.Details.Id = this.Id;

                DBLayer.Users.Update(this.Details);

                this.urDet.PercentForClients = Convert.ToDouble(tbAbonements.Text);
                this.urDet.PercentForSales = Convert.ToDouble(tbBar.Text);
                this.urDet.PercentForService = Convert.ToDouble(tbServices.Text);
                this.urDet.PercentForMassage = Convert.ToDouble(tbMassage.Text);
                this.urDet.PercentForFitness = Convert.ToDouble(tbFitness.Text);
                this.urDet.Constant = Convert.ToDouble(tbConstant.Text);
                this.urDet.UserId = this.Id;

                if (this.urDet.Id == 0)
                {
                    DBLayer.UserRate.Insert(urDet);
                }
                else
                {
                    DBLayer.UserRate.Update(urDet);
                }

                this.Close();
            }
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            DataForms.FrmAdministrators frm = new FrmAdministrators();
            frm.SelectAdminMsg += new FrmAdministrators.AdminEventHandler(frm_SelectAdminMsg);
            frm.ShowDialog();
        }

        void frm_SelectAdminMsg(object sender, FrmAdministrators.AdminEventArgs args)
        {
            DBLayer.UserAdministrator.UserAdministrator_Details det = new FitnessProject.DBLayer.UserAdministrator.UserAdministrator_Details();

            det.AdministratorId = args.Id;
            det.UserId = this.Id;

            DBLayer.UserAdministrator.Insert(det);

            LoadAdminsData();
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы действительно хотите удалить администратора из смены", "Фитнесс", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] i;
                int SelRow = -1;
                i = advBandedGridView2.GetSelectedRows();
                SelRow = i[0];

                int ind = 0;

                try
                {
                    ind = Convert.ToInt32(advBandedGridView2.GetRowCellValue(SelRow, "Id"));
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //MessageBox.Show(ind.ToString());
                                
                DBLayer.UserAdministrator.Delete(ind);

                LoadAdminsData();
            }
        }
    }
}
