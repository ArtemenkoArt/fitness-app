namespace FitnessProject.Components
{
    partial class CtrlArrivals
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlArrivals));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnToday = new System.Windows.Forms.ToolStripButton();
            this.tbtnMonth = new System.Windows.Forms.ToolStripButton();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateFrom = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateTill = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateTill = new System.Windows.Forms.ToolStripButton();
            this.tbtnChoose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.grGoods = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.sbTotal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.sbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnToday,
            this.tbtnMonth,
            this.tbtnAdd,
            this.tbtnEdit,
            this.tbtnRemove,
            this.toolStripSeparator1,
            this.tbtnExcel,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tbDateFrom,
            this.tbtnDateFrom,
            this.toolStripLabel2,
            this.tbDateTill,
            this.tbtnDateTill,
            this.tbtnChoose,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnToday
            // 
            this.tbtnToday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnToday.Image = ((System.Drawing.Image)(resources.GetObject("tbtnToday.Image")));
            this.tbtnToday.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnToday.Name = "tbtnToday";
            this.tbtnToday.Size = new System.Drawing.Size(23, 22);
            this.tbtnToday.Text = "Установить в текущую дату";
            this.tbtnToday.Click += new System.EventHandler(this.tbtnToday_Click);
            // 
            // tbtnMonth
            // 
            this.tbtnMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMonth.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMonth.Image")));
            this.tbtnMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMonth.Name = "tbtnMonth";
            this.tbtnMonth.Size = new System.Drawing.Size(23, 22);
            this.tbtnMonth.Text = "Текущий месяц";
            this.tbtnMonth.Click += new System.EventHandler(this.tbtnMonth_Click);
            // 
            // tbtnAdd
            // 
            this.tbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
            this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdd.Name = "tbtnAdd";
            this.tbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tbtnAdd.Text = "Добавить";
            this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
            // 
            // tbtnEdit
            // 
            this.tbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEdit.Image")));
            this.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEdit.Name = "tbtnEdit";
            this.tbtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tbtnEdit.Text = "Редактировать";
            this.tbtnEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
            // 
            // tbtnRemove
            // 
            this.tbtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRemove.Image")));
            this.tbtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRemove.Name = "tbtnRemove";
            this.tbtnRemove.Size = new System.Drawing.Size(23, 22);
            this.tbtnRemove.Text = "Удалить";
            this.tbtnRemove.Click += new System.EventHandler(this.tbtnRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnExcel
            // 
            this.tbtnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExcel.Image")));
            this.tbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcel.Name = "tbtnExcel";
            this.tbtnExcel.Size = new System.Drawing.Size(23, 22);
            this.tbtnExcel.Text = "Экспорт в Excel";
            this.tbtnExcel.Click += new System.EventHandler(this.tbtnExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(21, 22);
            this.toolStripLabel1.Text = "От";
            // 
            // tbDateFrom
            // 
            this.tbDateFrom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDateFrom.Name = "tbDateFrom";
            this.tbDateFrom.ReadOnly = true;
            this.tbDateFrom.Size = new System.Drawing.Size(100, 25);
            // 
            // tbtnDateFrom
            // 
            this.tbtnDateFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDateFrom.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDateFrom.Image")));
            this.tbtnDateFrom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDateFrom.Name = "tbtnDateFrom";
            this.tbtnDateFrom.Size = new System.Drawing.Size(23, 22);
            this.tbtnDateFrom.Click += new System.EventHandler(this.tbtnDateFrom_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel2.Text = "До";
            // 
            // tbDateTill
            // 
            this.tbDateTill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDateTill.Name = "tbDateTill";
            this.tbDateTill.ReadOnly = true;
            this.tbDateTill.Size = new System.Drawing.Size(100, 25);
            // 
            // tbtnDateTill
            // 
            this.tbtnDateTill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDateTill.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDateTill.Image")));
            this.tbtnDateTill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDateTill.Name = "tbtnDateTill";
            this.tbtnDateTill.Size = new System.Drawing.Size(23, 22);
            this.tbtnDateTill.Click += new System.EventHandler(this.tbtnDateTill_Click);
            // 
            // tbtnChoose
            // 
            this.tbtnChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnChoose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnChoose.Image")));
            this.tbtnChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnChoose.Name = "tbtnChoose";
            this.tbtnChoose.Size = new System.Drawing.Size(23, 22);
            this.tbtnChoose.Text = "Выбрать месяц";
            this.tbtnChoose.Click += new System.EventHandler(this.tbtnChoose_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // grGoods
            // 
            this.grGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grGoods.EmbeddedNavigator.Name = "";
            this.grGoods.Location = new System.Drawing.Point(0, 25);
            this.grGoods.MainView = this.advBandedGridView1;
            this.grGoods.Name = "grGoods";
            this.grGoods.Size = new System.Drawing.Size(725, 512);
            this.grGoods.TabIndex = 6;
            this.grGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn2,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8});
            this.advBandedGridView1.GridControl = this.grGoods;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Поставки";
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn6);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 637;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Поставщик";
            this.bandedGridColumn4.FieldName = "Supplier";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.Width = 106;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Дата";
            this.bandedGridColumn3.FieldName = "Date";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.Width = 107;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Продукт";
            this.bandedGridColumn2.FieldName = "Good";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Стоимость";
            this.bandedGridColumn6.FieldName = "Cost";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn6.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "Количество";
            this.bandedGridColumn7.FieldName = "Quantity";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn7.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Итого";
            this.bandedGridColumn5.FieldName = "Total";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.Width = 199;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Id";
            this.bandedGridColumn1.FieldName = "Id";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "Ед. измерения";
            this.bandedGridColumn8.FieldName = "Dimension";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn8.Visible = true;
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // sbTotal
            // 
            this.sbTotal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slblTotal});
            this.sbTotal.Location = new System.Drawing.Point(0, 515);
            this.sbTotal.Name = "sbTotal";
            this.sbTotal.Size = new System.Drawing.Size(725, 22);
            this.sbTotal.TabIndex = 7;
            this.sbTotal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Итого:";
            // 
            // slblTotal
            // 
            this.slblTotal.Name = "slblTotal";
            this.slblTotal.Size = new System.Drawing.Size(0, 17);
            // 
            // CtrlArrivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbTotal);
            this.Controls.Add(this.grGoods);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlArrivals";
            this.Size = new System.Drawing.Size(725, 537);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.sbTotal.ResumeLayout(false);
            this.sbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripButton tbtnEdit;
        private System.Windows.Forms.ToolStripButton tbtnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private DevExpress.XtraGrid.GridControl grGoods;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private System.Windows.Forms.StatusStrip sbTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbDateFrom;
        private System.Windows.Forms.ToolStripButton tbtnDateFrom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbDateTill;
        private System.Windows.Forms.ToolStripButton tbtnDateTill;
        private System.Windows.Forms.ToolStripButton tbtnChoose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbtnToday;
        private System.Windows.Forms.ToolStripButton tbtnMonth;
    }
}
