using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using Allenwood.VideoCaptureNet;

namespace FitnessProject.DataForms
{
    public partial class FrmEditCoach : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Coaches.Details Details = new FitnessProject.DBLayer.Coaches.Details();

        #endregion

        #region LoadList

        private void LoadList()
        {
            //ArrayList al = DBLayer.Abonements.GetList();

            //ArrayList al2 = DBLayer.CoachesAbonements.GetListByCoach(this.Id);

            //for (int i = 0; i < al.Count; i++)
            //{
            //    DBLayer.Abonements.Details det = (DBLayer.Abonements.Details)al[i];

            //    if (det.AbonementGroup == 1)
            //    {
            //        ListViewItem lvi = new ListViewItem();

            //        lvi.Tag = det.Id;
            //        lvi.Text = det.Name;

            //        for (int j = 0; j < al2.Count; j++)
            //        {
            //            DBLayer.CoachesAbonements.CoachesAbonements_WideDetails det2 = (DBLayer.CoachesAbonements.CoachesAbonements_WideDetails)al2[j];

            //            if (det2.AbonementId == det.Id)
            //            {
            //                lvi.Checked = true;
            //            }
            //        }

            //            lvAbonements.Items.Add(lvi);
            //    }
            //}

            
        }

        #endregion

        public FrmEditCoach()
        {
            InitializeComponent();
        }

        public FrmEditCoach(int id)
        {
            InitializeComponent();

            this.Id = id;

            this.Details = DBLayer.Coaches.GetDetails(id);

            tbName.Text = this.Details.Name;
            tbPhone.Text = this.Details.Phone;
            if (this.Details.HireDate != DateTime.MinValue)
                dtpHireDate.Value = this.Details.HireDate;

            if (this.Details.FireDate != DateTime.MinValue)
                dtpFireDate.Value = this.Details.FireDate;

            if (this.Details.BirthDate != DateTime.MinValue)
            {
                dtpBirthdate.Value = this.Details.BirthDate;
            }

            if (this.Details.Sex != -1)
            {
                cbSex.SelectedIndex = this.Details.Sex;
            }

            if (this.Details.Type != -1)
            {
                cbType.SelectedIndex = this.Details.Type;
            }

            byte[] result = DBLayer.Coaches.DownloadPhoto(Id);
            try
            {
                MemoryStream ms = new MemoryStream(result, 0, result.Length);

                //ms.Write(photo, 0, ms.Length);
                Image im = Image.FromStream(ms);
                pbPhoto.Image = im;
            }
            catch (Exception ee)
            {
                pbPhoto.Image = null;
            }

            LoadList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBLayer.Coaches.DeleteByAbonements(this.Id);

            this.Details.Name = tbName.Text;
            this.Details.Phone = tbPhone.Text;
            this.Details.HireDate = dtpHireDate.Value;

            this.Details.BirthDate = dtpBirthdate.Value;

            if (cbSex.SelectedItem != null)
            {
                this.Details.Sex = cbSex.SelectedIndex;
            }

            if (cbType.SelectedItem != null)
            {
                this.Details.Type = cbType.SelectedIndex;
            }

            if (cbFired.Checked)
            {
                this.Details.FireDate = dtpFireDate.Value;
            }

            //for (int i = 0; i < lvAbonements.Items.Count; i++)
            //{
            //    ListViewItem lvi = lvAbonements.Items[i];

            //    if (lvi.Checked)
            //    {
            //        DBLayer.CoachesAbonements.CoachesAbonements_Details det = new FitnessProject.DBLayer.CoachesAbonements.CoachesAbonements_Details();

            //        det.AbonementId = Convert.ToInt32(lvi.Tag);
            //        det.CoachId = this.Id;

            //        DBLayer.CoachesAbonements.Insert(det);
            //    }
            //}

                if (this.Id == 0)
                {
                    this.Id = DBLayer.Coaches.Insert(this.Details);

                    this.Close();
                }
                else
                {
                    this.Details.Id = this.Id;

                    DBLayer.Coaches.Update(this.Details);

                    this.Close();
                }

                try
                {
                    if (this.photo.Length > 0)
                        DBLayer.Coaches.UploadPhoto(this.photo, this.Id);
                    
                }
                catch
                {
                    DBLayer.Coaches.RemovePhoto(this.Id);
                }
        }

        private void FrmEditCoach_Load(object sender, EventArgs e)
        {

        }

        private byte[] photo;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (ofdSelect2D.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(ofdSelect2D.FileName, FileMode.Open);

                    FileInfo fi = new FileInfo(ofdSelect2D.FileName);
                    long temp = fi.Length;
                    int lung = Convert.ToInt32(temp);

                    byte[] plan = new byte[lung];
                    fs.Read(plan, 0, lung);
                    fs.Close();

                    this.photo = plan;

                    try
                    {
                        MemoryStream ms = new MemoryStream(plan, 0, plan.Length);
                        Image im = Image.FromStream(ms);
                        pbPhoto.Image = im;
                    }
                    catch (Exception ee)
                    {
                        pbPhoto.Image = null;
                    }

                    if (this.Id != 0)
                    {
                        if (plan.Length > 0)
                            DBLayer.Clients.UploadPhoto(plan, this.Id);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            try
            {
                //if (VideoCaptureDevice.Enabled)
                //    VideoCaptureDevice.Enabled = false;
            }
            catch { }
        }

        //VideoCaptureFrameEventArgs LastFrame = null;

        //public VideoCaptureDevice VideoCaptureDevice
        //{
        //    get
        //    {
        //        return VideoCaptureDeviceRep;
        //    }
        //    set
        //    {
        //        if (VideoCaptureDeviceRep != null)
        //            VideoCaptureDeviceRep.FrameCaptured -= new VideoCaptureFrameEventHandler(HandleFrame);
        //        VideoCaptureDeviceRep = value;
        //        if (VideoCaptureDeviceRep != null)
        //            VideoCaptureDeviceRep.FrameCaptured += new VideoCaptureFrameEventHandler(HandleFrame);
        //        //this.listBox1.Items.Clear();
        //        /*foreach (Size s in VideoCaptureDeviceRep.GetResolutionCaps())
        //        {
        //            this.listBox1.Items.Add(s);
        //        }
        //        this.Text = value.Desc.Name;*/

        //        VideoCaptureDevice.Properties.Brightness.Value = VideoCaptureDevice.Properties.Brightness.Default;
        //        VideoCaptureDevice.Properties.Contrast.Value = VideoCaptureDevice.Properties.Contrast.Default;
        //        //ResetTrackbarsBasedOnProperties();


        //    }
        //}
        //VideoCaptureDevice VideoCaptureDeviceRep;

        //public void HandleFrame(object sender, VideoCaptureFrameEventArgs e)
        //{
        //    //TotalFramesCounted++;
        //    LastFrame = e;
        //    //this.label1.Text = ""+e.SampleTime + " size " + e.Bytes.Length;

        //    VideoCaptureFrameEventArgs lastFrame = LastFrame;
        //    if (lastFrame == null) return;
        //    //			Byte[] bytesToUse = lastFrame.Bytes;
        //    //			Bitmap b = new Bitmap(lastFrame.Resolution.Width, lastFrame.Resolution.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        //    //			BitmapData bmd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        //    //			byte * scan0 = (byte*)bmd.Scan0.ToPointer();
        //    //			int numToDo = lastFrame.Resolution.Width * lastFrame.Resolution.Height * 3;
        //    //			for (int i = 0; i < numToDo; i++)
        //    //			{
        //    //				scan0[i] = bytesToUse[i];
        //    //			}
        //    //			b.UnlockBits(bmd);


        //    Bitmap b = lastFrame.GetBitmap();

        //    //if (this.Photo == null)
        //    this.pbPhoto.Image = b;
        //    this.Photo = b;
        //    /*if (this.pbPhoto.Width != b.Width) this.pictureBox1.Width = b.Width;
        //    if (this.pictureBox1.Height != b.Height) this.pictureBox1.Height = b.Height; */

        //}

        //Bitmap Photo;

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();

            foreach (VideoCaptureDeviceDesc vcdd in VideoCaptureDeviceDesc.GetAvailableDeviceDescs())
            {
                al.Add(vcdd);
            }

            if (al.Count == 0)
            {
                MessageBox.Show(this, "Вебкамера не обнаружена!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //VideoCaptureDeviceDesc vcdd = (VideoCaptureDeviceDesc)al[0];
                //MessageBox.Show(vcdd.Name);

                //this.VideoCaptureDevice = new VideoCaptureDevice(vcdd);

                //VideoCaptureDevice.Enabled = true;

            }

            btnPhoto.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();
            //this.Photo.Save(ms, ImageFormat.Bmp);
            //this.photo = ms.ToArray();

            //VideoCaptureDevice.Enabled = false;
            //pbPhoto.Image = this.Photo;

            //VideoCaptureDevice.Dispose();

            btnPhoto.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.photo = null;

            pbPhoto.Image = null;
        }
    }
}
