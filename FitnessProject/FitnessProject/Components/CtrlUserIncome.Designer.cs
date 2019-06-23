namespace FitnessProject.Components
{
    partial class CtrlUserIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlUserIncome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnMonth = new System.Windows.Forms.ToolStripButton();
            this.tbtnToday = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateFrom = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateTill = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateTill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnChoose = new System.Windows.Forms.ToolStripButton();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblRest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.grSales = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn13 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnMonth,
            this.tbtnToday,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbDateFrom,
            this.tbtnDateFrom,
            this.toolStripLabel2,
            this.tbDateTill,
            this.tbtnDateTill,
            this.toolStripSeparator2,
            this.tbtnChoose,
            this.tbtnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Экспорт в Excel";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.tbDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDateFrom_KeyDown);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(21, 22);
            this.toolStripLabel2.Text = "До";
            // 
            // tbDateTill
            // 
            this.tbDateTill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDateTill.Name = "tbDateTill";
            this.tbDateTill.ReadOnly = true;
            this.tbDateTill.Size = new System.Drawing.Size(100, 25);
            this.tbDateTill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDateTill_KeyDown);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblRest);
            this.pnlTotal.Controls.Add(this.label1);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 540);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(914, 62);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRest.Location = new System.Drawing.Point(149, 24);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(24, 25);
            this.lblRest.TabIndex = 1;
            this.lblRest.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итого:";
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "зарплата";
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // grSales
            // 
            this.grSales.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grSales.EmbeddedNavigator.Name = "";
            this.grSales.Location = new System.Drawing.Point(0, 25);
            this.grSales.MainView = this.advBandedGridView1;
            this.grSales.Name = "grSales";
            this.grSales.Size = new System.Drawing.Size(914, 515);
            this.grSales.TabIndex = 3;
            this.grSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.gridView2});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8,
            this.bandedGridColumn9,
            this.bandedGridColumn10,
            this.bandedGridColumn11,
            this.bandedGridColumn12,
            this.bandedGridColumn13});
            this.advBandedGridView1.GridControl = this.grSales;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Доходы смен";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn10);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn11);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Columns.Add(this.bandedGridColumn6);
            this.gridBand1.Columns.Add(this.bandedGridColumn12);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Columns.Add(this.bandedGridColumn8);
            this.gridBand1.Columns.Add(this.bandedGridColumn13);
            this.gridBand1.Columns.Add(this.bandedGridColumn9);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 975;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Смена";
            this.bandedGridColumn1.FieldName = "User";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Продажи абонементов";
            this.bandedGridColumn2.FieldName = "Abonements";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Продажи товаров";
            this.bandedGridColumn3.FieldName = "Goods";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn3.Visible = true;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Продажи услуг";
            this.bandedGridColumn4.FieldName = "Services";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Ставка";
            this.bandedGridColumn5.FieldName = "Constant";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn5.Visible = true;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Зарплата за абонементы";
            this.bandedGridColumn6.FieldName = "AbonementIncome";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn6.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "Зарплата за бар";
            this.bandedGridColumn7.FieldName = "GoodsIncome";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn7.Visible = true;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "Зарплата за услуги";
            this.bandedGridColumn8.FieldName = "ServiceIncome";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn8.Visible = true;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.Caption = "Итого";
            this.bandedGridColumn9.FieldName = "Total";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn9.Visible = true;
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.Caption = "Продажи аэробика";
            this.bandedGridColumn10.FieldName = "AbonementFitness";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            this.bandedGridColumn10.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn10.Visible = true;
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.Caption = "Продажи массаж";
            this.bandedGridColumn11.FieldName = "ServiceMassage";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            this.bandedGridColumn11.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn11.Visible = true;
            // 
            // bandedGridColumn12
            // 
            this.bandedGridColumn12.Caption = "Зарплата (аэробика)";
            this.bandedGridColumn12.FieldName = "ClientFitnessIncome";
            this.bandedGridColumn12.Name = "bandedGridColumn12";
            this.bandedGridColumn12.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn12.Visible = true;
            // 
            // bandedGridColumn13
            // 
            this.bandedGridColumn13.Caption = "Зарплата (массаж)";
            this.bandedGridColumn13.FieldName = "ServiceMassageIncome";
            this.bandedGridColumn13.Name = "bandedGridColumn13";
            this.bandedGridColumn13.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn13.Visible = true;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grSales;
            this.gridView2.Name = "gridView2";
            // 
            // CtrlUserIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grSales);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlUserIncome";
            this.Size = new System.Drawing.Size(914, 602);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tbtnToday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbDateFrom;
        private System.Windows.Forms.ToolStripButton tbtnDateFrom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbDateTill;
        private System.Windows.Forms.ToolStripButton tbtnDateTill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.ToolStripButton tbtnChoose;
        private DevExpress.XtraGrid.GridControl grSales;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton tbtnMonth;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn13;
    }
}
