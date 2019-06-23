namespace FitnessProject.Components
{
    partial class CtrlDeclines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDeclines));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnToday = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateFrom = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateTill = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnDateTill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblAbonements = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblGoods = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblServices = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblRest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grSales = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnToday,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbDateFrom,
            this.tbtnDateFrom,
            this.toolStripLabel2,
            this.tbDateTill,
            this.tbtnDateTill,
            this.toolStripSeparator2,
            this.tbtnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Экспорт в Excel";
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
            // tbtnExcel
            // 
            this.tbtnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExcel.Image")));
            this.tbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcel.Name = "tbtnExcel";
            this.tbtnExcel.Size = new System.Drawing.Size(23, 22);
            this.tbtnExcel.Text = "toolStripButton4";
            this.tbtnExcel.Click += new System.EventHandler(this.tbtnExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.slblAbonements,
            this.toolStripStatusLabel1,
            this.slblGoods,
            this.toolStripStatusLabel3,
            this.slblServices});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel2.Text = "Продажа абонементов:";
            // 
            // slblAbonements
            // 
            this.slblAbonements.Name = "slblAbonements";
            this.slblAbonements.Size = new System.Drawing.Size(13, 17);
            this.slblAbonements.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Продажа товаров:";
            // 
            // slblGoods
            // 
            this.slblGoods.Name = "slblGoods";
            this.slblGoods.Size = new System.Drawing.Size(13, 17);
            this.slblGoods.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel3.Text = "Продажа услуг:";
            // 
            // slblServices
            // 
            this.slblServices.Name = "slblServices";
            this.slblServices.Size = new System.Drawing.Size(13, 17);
            this.slblServices.Text = "0";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblRest);
            this.pnlTotal.Controls.Add(this.label1);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 518);
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
            this.grSales.Size = new System.Drawing.Size(914, 493);
            this.grSales.TabIndex = 3;
            this.grSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.advBandedGridView1.GridControl = this.grSales;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.ColumnFilterChanged += new System.EventHandler(this.advBandedGridView1_ColumnFilterChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Отказы";
            this.gridBand1.Columns.Add(this.gridColumn1);
            this.gridBand1.Columns.Add(this.gridColumn2);
            this.gridBand1.Columns.Add(this.gridColumn3);
            this.gridBand1.Columns.Add(this.gridColumn4);
            this.gridBand1.Columns.Add(this.gridColumn5);
            this.gridBand1.Columns.Add(this.gridColumn6);
            this.gridBand1.Columns.Add(this.gridColumn7);
            this.gridBand1.Columns.Add(this.gridColumn8);
            this.gridBand1.Columns.Add(this.gridColumn9);
            this.gridBand1.Columns.Add(this.gridColumn10);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 900;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Группа";
            this.gridColumn1.FieldName = "Group";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Товар/услуга";
            this.gridColumn2.FieldName = "Good";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Стоимость";
            this.gridColumn3.FieldName = "Cost";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Дата продажи";
            this.gridColumn4.FieldName = "Date";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Время продажи";
            this.gridColumn5.FieldName = "Time";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Продавшая смена";
            this.gridColumn6.FieldName = "User";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Стоимость";
            this.gridColumn7.FieldName = "Cost";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Количество";
            this.gridColumn8.FieldName = "Quantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Итого";
            this.gridColumn9.FieldName = "Total";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Единица измерения";
            this.gridColumn10.FieldName = "Dimension";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Дата отмены";
            this.bandedGridColumn1.FieldName = "DeleteDate";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Причина отмены";
            this.bandedGridColumn2.FieldName = "DeleteReason";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // CtrlDeclines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grSales);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlDeclines";
            this.Size = new System.Drawing.Size(914, 602);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblGoods;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel slblServices;
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slblAbonements;
        private DevExpress.XtraGrid.GridControl grSales;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn10;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
    }
}
