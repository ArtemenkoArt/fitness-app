using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.ServiceForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            //MessageBox.Show(Properties.Settings.Default.ConnectionString);

            ZFort.DB.ConnectionString.Value = Properties.Settings.Default.ConnectionString;
        }

        #region Authorize

        public void Authorize()
        {
            //Database.Service1 serv = new FitnessProject.Database.Service1();

            //serv.Initialize();

            DBLayer.Users.Details det = DBLayer.Users.Authorize(tbLogin.Text, tbPassword.Text);

            if (det.Id != 0)
            {
                AppDomain.CurrentDomain.SetData("User", det);

                DBLayer.UserVisits.UserVisits_Details detV = new FitnessProject.DBLayer.UserVisits.UserVisits_Details();

                detV.Date = DateTime.Now.Date;
                detV.TimeOn = DateTime.Now.ToString("hh:mm");
                detV.UserId = det.Id;

                DBLayer.UserVisits.Insert(detV);

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Неправильный логин или пароль!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            Authorize();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorize();
            }
        }
    }
}
