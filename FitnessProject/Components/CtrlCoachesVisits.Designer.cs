namespace FitnessProject.Components
{
    partial class CtrlCoachesVisits
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlCoachesVisits));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.grSales = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnMonth,
            this.toolStripSeparator1,
            this.tbtnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnMonth
            // 
            this.tbtnMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMonth.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMonth.Image")));
            this.tbtnMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMonth.Name = "tbtnMonth";
            this.tbtnMonth.Size = new System.Drawing.Size(23, 22);
            this.tbtnMonth.Text = "Выбор месяца";
            this.tbtnMonth.Click += new System.EventHandler(this.tbtnMonth_Click);
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
            // grSales
            // 
            this.grSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grSales.Location = new System.Drawing.Point(0, 25);
            this.grSales.MainView = this.advBandedGridView1;
            this.grSales.Name = "grSales";
            this.grSales.Size = new System.Drawing.Size(922, 507);
            this.grSales.TabIndex = 5;
            this.grSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.grSales.Click += new System.EventHandler(this.grSales_Click);
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
            this.bandedGridColumn5});
            this.advBandedGridView1.GridControl = this.grSales;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Посещения тренера";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 761;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Тренер";
            this.bandedGridColumn1.FieldName = "FIO";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 300;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Абонементы";
            this.bandedGridColumn2.FieldName = "Abonements";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 90;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Разовые";
            this.bandedGridColumn3.FieldName = "Single";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Комбинированные абонементы/Замены";
            this.bandedGridColumn4.FieldName = "Substitutions";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.Width = 221;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Итого";
            this.bandedGridColumn5.FieldName = "Total";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Итого:";
            // 
            // slblCount
            // 
            this.slblCount.Name = "slblCount";
            this.slblCount.Size = new System.Drawing.Size(13, 17);
            this.slblCount.Text = "0";
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // CtrlCoachesVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grSales);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlCoachesVisits";
            this.Size = new System.Drawing.Size(922, 532);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnMonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl grSales;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblCount;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
    }
}
