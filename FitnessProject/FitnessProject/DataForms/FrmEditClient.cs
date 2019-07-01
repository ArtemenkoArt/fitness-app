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
    public partial class FrmEditClient : Form
    {
        #region Fields

        public int Id = 0;
        DBLayer.Clients.Details Details = new FitnessProject.DBLayer.Clients.Details();

        private byte[] photo;

        public ArrayList Abonements = new ArrayList();

        private bool BarcodeChanged = false;

        #endregion

        #region LoadGroups

        private void LoadGroups(int id)
        {
            ArrayList al = DBLayer.ClientTypes.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.ClientTypes.Details det = (DBLayer.ClientTypes.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbClientType.Items.Add(li);
            }

            for (int i = 0; i < cbClientType.Items.Count; i++)
            {
                Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbClientType.Items[i];

                if (li.ID == id)
                {
                    cbClientType.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region LoadSources

        private void LoadSources(int id)
        {
            ArrayList al = DBLayer.AdvertisingSource.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.AdvertisingSource.Details det = (DBLayer.AdvertisingSource.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbSource.Items.Add(li);
            }

            for (int i = 0; i < cbSource.Items.Count; i++)
            {
                Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbSource.Items[i];

                if (li.ID == id)
                {
                    cbSource.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region LoadDocument

        private void LoadDocument(int id)
        {
            ArrayList al = DBLayer.DocumentType.GetList();

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.DocumentType.Details det = (DBLayer.DocumentType.Details)al[i];

                Lib.ServiceFunctions.ListItem li = new FitnessProject.Lib.ServiceFunctions.ListItem();

                li.ID = det.Id;
                li.Name = det.Name;

                cbDocumentType.Items.Add(li);
            }

            for (int i = 0; i < cbDocumentType.Items.Count; i++)
            {
                Lib.ServiceFunctions.ListItem li = (Lib.ServiceFunctions.ListItem)cbDocumentType.Items[i];

                if (li.ID == id)
                {
                    cbDocumentType.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        public FrmEditClient()
        {
            InitializeComponent();

            btnOk.Enabled = false;

            LoadGroups(0);
            LoadSources(0);
            LoadDocument(0);

            tbRegisterDate.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");

            LoadData();
        }

        public FrmEditClient(bool val)
        {
            InitializeComponent();

            btnOk.Enabled = true;
            cbDocumentType.Enabled = false;
            tbDocumentNumber.Enabled = false;

            tbCode.Enabled = false;
            btnCheck.Enabled = false;

            LoadGroups(0);
            LoadSources(0);
            LoadDocument(0);

            tbRegisterDate.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = new ArrayList();

            if (this.Id != 0)
            {
                al = DBLayer.ClientsAbonements.GetList(this.Id);
                Abonements = al;
            }
            else
            {
                al = Abonements;
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Coach");
            dt.Columns.Add("Time");
            dt.Columns.Add("Weekdays");
            dt.Columns.Add("DateStart", typeof(DateTime));
            dt.Columns.Add("DateFinish", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.ClientsAbonements.ClientsAbonements_WideDetails det = (DBLayer.ClientsAbonements.ClientsAbonements_WideDetails) al[i];

                dr["Id"] = det.Id;
                dr["Name"] = det.Name;
                dr["DateStart"] = det.DateStart;
                dr["DateFinish"] = det.DateFinish;

                dr["Coach"] = det.CoachName;
                dr["Time"] = det.Time;
                dr["Weekdays"] = det.Weekdays;
            }

            grAbonements.DataSource = dt;
            advBandedGridView2.BestFitColumns();

            
        }

        #endregion

        public FrmEditClient(int id)
        {
            InitializeComponent();

            //btnOk.Enabled = false;

            this.Id = id;

            this.Details = DBLayer.Clients.GetDetails(id);

            tbFIO.Text = this.Details.FIO;
            tbCode.Text = this.Details.Barcode;
            tbRegisterDate.Text = this.Details.RegisterDate.ToString("dd-MMM-yyyy");

            tbDay.Text = this.Details.BirthDate.Date.Day.ToString();
            cbMonth.SelectedIndex = this.Details.BirthDate.Date.Month - 1;
            tbYear.Text = this.Details.BirthDate.Date.Year.ToString();
            tbDocumentNumber.Text = this.Details.DocumentNumber;
            tbPhone.Text = this.Details.Phone;

            LoadGroups(this.Details.TypeId);
            LoadSources(this.Details.SourceId);
            LoadDocument(this.Details.DocumentId);

            byte[] result = DBLayer.Clients.DownloadPhoto(Id);
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

            LoadData();

            cbSex.SelectedIndex = Details.Sex;
        }

        private void btnClientType_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frmC1 = new FitnessProject.ServiceForms.FrmCalendar();
            frmC1.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frmC1_SelectDateMsg);
            frmC1.ShowDialog();
        }

        void frmC1_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            tbRegisterDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
        }

        private void btnBirthDate_Click(object sender, EventArgs e)
        {
            ServiceForms.FrmCalendar frmC2 = new FitnessProject.ServiceForms.FrmCalendar();
            frmC2.SelectDateMsg += new FitnessProject.ServiceForms.FrmCalendar.SelectDateEventHandler(frmC2_SelectDateMsg);
            frmC2.ShowDialog();
        }

        void frmC2_SelectDateMsg(object sender, FitnessProject.ServiceForms.FrmCalendar.DateSelectEventArgs args)
        {
            //tbBirthDate.Text = args.SelectedDate.ToString("dd-MMM-yyyy");
        }

        #region Validation

        public bool Validation()
        {
            if (this.Abonements.Count == 0)
            {
                MessageBox.Show(this, "Не указан абонемент!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbSource.SelectedItem == null)
            {
                MessageBox.Show(this, "Не указан источник привлечения!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbClientType.SelectedItem == null)
            {
                MessageBox.Show(this, "Не указан тип клиента!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbDocumentType.Enabled)
            {
                if (cbDocumentType.SelectedItem == null)
                {
                    MessageBox.Show(this, "Не указан тип документа!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (cbSex.SelectedItem == null)
            {
                MessageBox.Show(this, "Не указан пол клиента!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbDocumentType.Enabled)
            {
                if (cbMonth.SelectedItem == null)
                {
                    MessageBox.Show(this, "Не указана дата рождения!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                

                try
                {
                    this.Details.BirthDate = new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, Convert.ToInt32(tbDay.Text));
                }
                catch
                {
                    this.Details.BirthDate = DateTime.Now;
                }

                try
                {
                    this.Details.DocumentId = ((Lib.ServiceFunctions.ListItem)cbDocumentType.SelectedItem).ID;
                    this.Details.DocumentNumber = tbDocumentNumber.Text;
                }
                catch
                {
                    this.Details.DocumentId = 0;
                }

                this.Details.FIO = tbFIO.Text;

                if (this.Details.FIO == "")
                    this.Details.FIO = "Разовый";

                this.Details.Phone = tbPhone.Text;

                this.Details.RegisterDate = Convert.ToDateTime(tbRegisterDate.Text);


                this.Details.SourceId = ((Lib.ServiceFunctions.ListItem)cbSource.SelectedItem).ID;
                this.Details.TypeId = ((Lib.ServiceFunctions.ListItem)cbClientType.SelectedItem).ID;

                this.Details.Sex = cbSex.SelectedIndex;

                if (this.Id == 0)
                {
                    this.Details.Barcode = Lib.ServiceFunctions.ScanPrefix() + tbCode.Text;

                    this.Id = DBLayer.Clients.Insert(this.Details);

                    try
                    {

                        for (int i = 0; i < Abonements.Count; i++)
                        {
                            DBLayer.ClientsAbonements.ClientsAbonements_WideDetails det = (DBLayer.ClientsAbonements.ClientsAbonements_WideDetails)Abonements[i];

                            DBLayer.ClientsAbonements.Details caDet = new FitnessProject.DBLayer.ClientsAbonements.Details();

                            DBLayer.Abonements.Details aDet = DBLayer.Abonements.GetDetails(det.AbonementId);

                            if (aDet.LessonsCount != 0)
                            {
                                caDet.VisitsCount = aDet.LessonsCount;
                            }

                            if (aDet.AdditionalVisits != 0)
                            {
                                caDet.AdditionalCount = aDet.AdditionalVisits;
                            }

                            caDet.AbonementId = det.AbonementId;
                            caDet.ClientId = this.Id;

                            
                            caDet.DateFinish = det.DateFinish;
                            caDet.DateStart = det.DateStart;

                            caDet.CoachId = det.CoachId;
                            caDet.Weekdays = det.Weekdays;
                            caDet.Time = det.Time;

                            int caId = DBLayer.ClientsAbonements.Insert(caDet);

                            if (MessageBox.Show(this, "Провести платеж " + DBLayer.Abonements.GetDetails(caDet.AbonementId).Cost.ToString() + "?", Lib.StringConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DBLayer.AbonementIncome.Details detAI = new FitnessProject.DBLayer.AbonementIncome.Details();

                                detAI.ClientAbonementId = caId;
                                detAI.AbonementId = caDet.AbonementId;
                                detAI.ClientId = caDet.ClientId;
                                detAI.Date = DateTime.Now.Date;
                                detAI.Summ = DBLayer.Abonements.GetDetails(caDet.AbonementId).Cost;
                                detAI.UserId = ((DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User")).Id;

                                DBLayer.AbonementIncome.Insert(detAI);
                            }
                        }

                        //MessageBox.Show(this.photo.Length.ToString());
                        try
                        {
                            if (this.photo.Length > 0)
                                DBLayer.Clients.UploadPhoto(this.photo, this.Id);                            
                        }
                        catch
                        {
                            DBLayer.Clients.RemovePhoto(this.Id);
                        }

                    }
                    catch { }

                    if (MessageBox.Show(this, "Провести клиента в зал?", Lib.StringConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SimulateSelectClient();
                    }
                }
                else
                {
                    if (this.BarcodeChanged)
                    {
                        this.Details.Barcode = Lib.ServiceFunctions.ScanPrefix() + tbCode.Text;
                        this.BarcodeChanged = false;
                    }
                    else
                    {
                        this.Details.Barcode = tbCode.Text;
                    }

                    DBLayer.Clients.Update(this.Details);

                    //MessageBox.Show(this.photo.Length.ToString());
                    try
                    {
                        if (this.photo.Length > 0)
                            DBLayer.Clients.UploadPhoto(this.photo, this.Id);
                        //else
                        //    DBLayer.Clients.RemovePhoto(this.Id);
                    }
                    catch
                    {
                        //DBLayer.Clients.RemovePhoto(this.Id);
                    }
                }

                this.Close();
            }
        }

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
                if (VideoCaptureDevice.Enabled)
                    VideoCaptureDevice.Enabled = false;
            }
            catch { }
        }

        #region Client Select Event

        public delegate void SelectClientHandler(object sender, ClientSelectEventArgs args);

        public event SelectClientHandler SelectClientMsg;

        protected virtual void OnSelectClient(ClientSelectEventArgs e)
        {
            if (SelectClientMsg != null)
            {
                SelectClientMsg(this, e);
            }
        }

        public void SimulateSelectClient()
        {
            ClientSelectEventArgs e = new ClientSelectEventArgs(this.Id);

            OnSelectClient(e);
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.Id == 0)
            {
                DataForms.FrmEditClientAbonement frm = new FrmEditClientAbonement();
                frm.SelectAbonementMsg += new FrmEditClientAbonement.SelectAbonementHandler(frm_SelectAbonementMsg);
                frm.ShowDialog();
            }
            else
            {
                DataForms.FrmEditClientAbonement frm = new FrmEditClientAbonement(DBLayer.Clients.GetDetails(this.Id));
                frm.ShowDialog();
            }

            LoadData();
        }

        void frm_SelectAbonementMsg(object sender, FrmEditClientAbonement.AbonementSelectEventArgs args)
        {
            DBLayer.Abonements.Details detA = DBLayer.Abonements.GetDetails(args.Details.AbonementId);

            if (detA.IsSingle)
                btnOk.Enabled = true;

            this.Abonements.Add(args.Details);

            LoadData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить абонемент?", Lib.StringData.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.Id != 0)
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

                    DBLayer.AbonementIncome.DeleteByClientAbonement(ind);

                    DBLayer.ClientsAbonements.Delete(ind);

                    DBLayer.ClientsAbonements.SetNewActual(this.Id);

                    LoadData();
                }
                else
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

                    DBLayer.ClientsAbonements.Delete(ind);

                    DBLayer.ClientsAbonements.SetNewActual(this.Id);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool val = DBLayer.Barcodes.Check("000" + tbCode.Text);

            if (!val)
            {
                MessageBox.Show(this, "Указанный номер карты не входит в реестр карт!", Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOk.Enabled = false;
            }
            else
            {
                MessageBox.Show("Проверка прошла успешно!");
                btnOk.Enabled = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

            DataForms.FrmEditClientAbonement frm = new FrmEditClientAbonement(ind);
            frm.ShowDialog();

            LoadData();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }



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
                VideoCaptureDeviceDesc vcdd = (VideoCaptureDeviceDesc)al[0];
                MessageBox.Show(vcdd.Name);

                this.VideoCaptureDevice = new VideoCaptureDevice(vcdd);

                VideoCaptureDevice.Enabled = true;

            }

            btnPhoto.Enabled = false;
            btnSave.Enabled = true;
        }

        VideoCaptureFrameEventArgs LastFrame = null;

        public VideoCaptureDevice VideoCaptureDevice
        {
            get
            {
                return VideoCaptureDeviceRep;
            }
            set
            {
                if (VideoCaptureDeviceRep != null)
                    VideoCaptureDeviceRep.FrameCaptured -= new VideoCaptureFrameEventHandler(HandleFrame);
                VideoCaptureDeviceRep = value;
                if (VideoCaptureDeviceRep != null)
                    VideoCaptureDeviceRep.FrameCaptured += new VideoCaptureFrameEventHandler(HandleFrame);
                //this.listBox1.Items.Clear();
                /*foreach (Size s in VideoCaptureDeviceRep.GetResolutionCaps())
                {
                    this.listBox1.Items.Add(s);
                }
                this.Text = value.Desc.Name;*/

                //VideoCaptureDevice.Properties.Brightness.Value = VideoCaptureDevice.Properties.Brightness.Default;
                //VideoCaptureDevice.Properties.Contrast.Value = VideoCaptureDevice.Properties.Contrast.Default;
                //ResetTrackbarsBasedOnProperties();


            }
        }
        VideoCaptureDevice VideoCaptureDeviceRep;

        public void HandleFrame(object sender, VideoCaptureFrameEventArgs e)
        {
            //TotalFramesCounted++;
            LastFrame = e;
            //this.label1.Text = ""+e.SampleTime + " size " + e.Bytes.Length;

            VideoCaptureFrameEventArgs lastFrame = LastFrame;
            if (lastFrame == null) return;
            //			Byte[] bytesToUse = lastFrame.Bytes;
            //			Bitmap b = new Bitmap(lastFrame.Resolution.Width, lastFrame.Resolution.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //			BitmapData bmd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //			byte * scan0 = (byte*)bmd.Scan0.ToPointer();
            //			int numToDo = lastFrame.Resolution.Width * lastFrame.Resolution.Height * 3;
            //			for (int i = 0; i < numToDo; i++)
            //			{
            //				scan0[i] = bytesToUse[i];
            //			}
            //			b.UnlockBits(bmd);


            Bitmap b = lastFrame.GetBitmap();

            //if (this.Photo == null)
            this.pbPhoto.Image = b;
            this.Photo = b;
            /*if (this.pbPhoto.Width != b.Width) this.pictureBox1.Width = b.Width;
            if (this.pictureBox1.Height != b.Height) this.pictureBox1.Height = b.Height; */

        }

        Bitmap Photo;

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            this.Photo.Save(ms, ImageFormat.Bmp);
            this.photo = ms.ToArray();

            VideoCaptureDevice.Enabled = false;
            pbPhoto.Image = this.Photo;

            VideoCaptureDevice.Dispose();

            btnPhoto.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.photo = null;

            pbPhoto.Image = null;
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCode_Leave(object sender, EventArgs e)
        {
            if (this.Id != 0)
            {
                if (tbCode.Text != this.Details.Barcode)
                {
                    BarcodeChanged = true;
                }
            }
        }
    }



    #region ClientSelectEventArgs Class

    public class ClientSelectEventArgs : EventArgs
    {
        #region Constructor

        public ClientSelectEventArgs(int id)
        {
            this.ClientId = id;
        }

        #endregion

        #region Fields

        public readonly int ClientId;

        #endregion
    }

    #endregion
}
