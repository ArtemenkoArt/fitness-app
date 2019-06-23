using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FitnessProject.ServiceForms
{
    public partial class FrmViewClient : Form
    {
        public FrmViewClient(DBLayer.Clients.Details det)
        {
            InitializeComponent();

            byte[] result = DBLayer.Clients.DownloadPhoto(det.Id);
            try
            {
                MemoryStream ms = new MemoryStream(result, 0, result.Length);
                Image im = Image.FromStream(ms);
                pbPhoto.Image = im;
            }
            catch (Exception ee)
            {
                pbPhoto.Image = null;
            }

            lblFIO.Text = det.FIO;
            lblBirthDate.Text = det.BirthDate.ToString("dd-MMM-yyyy");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
