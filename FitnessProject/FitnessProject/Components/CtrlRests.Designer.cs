namespace FitnessProject.Components
{
    partial class CtrlRests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlRests));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateStart = new System.Windows.Forms.ToolStripTextBox();
            this.btnDateStartSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbDateFinish = new System.Windows.Forms.ToolStripTextBox();
            this.btnDateFinishSelect = new System.Windows.Forms.ToolStripButton();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.grSales = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tbtnExcel,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbDateStart,
            this.btnDateStartSelect,
            this.toolStripLabel2,
            this.tbDateFinish,
            this.btnDateFinishSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Экспорт в Excel";
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
            this.tbtnExcel.Text = "Экспорт в Excel";
            this.tbtnExcel.Click += new System.EventHandler(this.tbtnExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel1.Text = "Начало интервала:";
            // 
            // tbDateStart
            // 
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.ReadOnly = true;
            this.tbDateStart.Size = new System.Drawing.Size(100, 25);
            this.tbDateStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDateStart_KeyDown);
            // 
            // btnDateStartSelect
            // 
            this.btnDateStartSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDateStartSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnDateStartSelect.Image")));
            this.btnDateStartSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDateStartSelect.Name = "btnDateStartSelect";
            this.btnDateStartSelect.Size = new System.Drawing.Size(23, 22);
            this.btnDateStartSelect.Text = "toolStripButton1";
            this.btnDateStartSelect.Click += new System.EventHandler(this.btnDateStartSelect_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel2.Text = "Конец интервала:";
            // 
            // tbDateFinish
            // 
            this.tbDateFinish.Name = "tbDateFinish";
            this.tbDateFinish.ReadOnly = true;
            this.tbDateFinish.Size = new System.Drawing.Size(100, 25);
            this.tbDateFinish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDateFinish_KeyDown);
            // 
            // btnDateFinishSelect
            // 
            this.btnDateFinishSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDateFinishSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnDateFinishSelect.Image")));
            this.btnDateFinishSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDateFinishSelect.Name = "btnDateFinishSelect";
            this.btnDateFinishSelect.Size = new System.Drawing.Size(23, 22);
            this.btnDateFinishSelect.Text = "toolStripButton2";
            this.btnDateFinishSelect.Click += new System.EventHandler(this.btnDateFinishSelect_Click);
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 28);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(214, 23);
            this.toolStripStatusLabel1.Text = "Общая капитализация:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 23);
            this.lblTotal.Text = "0";
            // 
            // grSales
            // 
            this.grSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grSales.Location = new System.Drawing.Point(0, 25);
            this.grSales.MainView = this.advBandedGridView1;
            this.grSales.Name = "grSales";
            this.grSales.Size = new System.Drawing.Size(914, 549);
            this.grSales.TabIndex = 4;
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
            this.gridColumn9,
            this.gridColumn10,
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3});
            this.advBandedGridView1.GridControl = this.grSales;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.DoubleClick += new System.EventHandler(this.advBandedGridView1_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Остатки товара";
            this.gridBand1.Columns.Add(this.gridColumn1);
            this.gridBand1.Columns.Add(this.gridColumn2);
            this.gridBand1.Columns.Add(this.gridColumn10);
            this.gridBand1.Columns.Add(this.gridColumn9);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 450;
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
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Единица измерения";
            this.gridColumn10.FieldName = "Dimension";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Остатки";
            this.gridColumn9.FieldName = "Total";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Отпускная стоимость";
            this.bandedGridColumn1.FieldName = "Price";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Капитализация";
            this.bandedGridColumn2.FieldName = "Cap";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Id";
            this.bandedGridColumn3.FieldName = "Id";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            // 
            // CtrlRests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grSales);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlRests";
            this.Size = new System.Drawing.Size(914, 602);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbDateStart;
        private System.Windows.Forms.ToolStripButton btnDateStartSelect;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbDateFinish;
        private System.Windows.Forms.ToolStripButton btnDateFinishSelect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private DevExpress.XtraGrid.GridControl grSales;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
    }
}
