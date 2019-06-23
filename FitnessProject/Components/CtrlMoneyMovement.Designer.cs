namespace FitnessProject.Components
{
    partial class CtrlMoneyMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlMoneyMovement));
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblAbonements = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblGoods = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblServices = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblCharges = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.slblIncome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChargesBig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grSales = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.toolStripSeparator3,
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
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 22);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.slblAbonements,
            this.toolStripStatusLabel1,
            this.slblGoods,
            this.toolStripStatusLabel3,
            this.slblServices,
            this.toolStripStatusLabel5,
            this.slblCharges});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(136, 17);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel3.Text = "Продажа услуг:";
            // 
            // slblServices
            // 
            this.slblServices.Name = "slblServices";
            this.slblServices.Size = new System.Drawing.Size(13, 17);
            this.slblServices.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel5.Text = "Расходы:";
            // 
            // slblCharges
            // 
            this.slblCharges.Name = "slblCharges";
            this.slblCharges.Size = new System.Drawing.Size(13, 17);
            this.slblCharges.Text = "0";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.slblIncome);
            this.pnlTotal.Controls.Add(this.label4);
            this.pnlTotal.Controls.Add(this.lblChargesBig);
            this.pnlTotal.Controls.Add(this.label3);
            this.pnlTotal.Controls.Add(this.lblRest);
            this.pnlTotal.Controls.Add(this.label1);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 518);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(914, 62);
            this.pnlTotal.TabIndex = 2;
            // 
            // slblIncome
            // 
            this.slblIncome.AutoSize = true;
            this.slblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slblIncome.Location = new System.Drawing.Point(168, 20);
            this.slblIncome.Name = "slblIncome";
            this.slblIncome.Size = new System.Drawing.Size(24, 25);
            this.slblIncome.TabIndex = 5;
            this.slblIncome.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поступления:";
            // 
            // lblChargesBig
            // 
            this.lblChargesBig.AutoSize = true;
            this.lblChargesBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChargesBig.Location = new System.Drawing.Point(467, 20);
            this.lblChargesBig.Name = "lblChargesBig";
            this.lblChargesBig.Size = new System.Drawing.Size(24, 25);
            this.lblChargesBig.TabIndex = 3;
            this.lblChargesBig.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(333, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Расходы:";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRest.Location = new System.Drawing.Point(708, 20);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(24, 25);
            this.lblRest.TabIndex = 1;
            this.lblRest.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(588, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Остаток:";
            // 
            // grSales
            // 
            this.grSales.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4});
            this.advBandedGridView1.GridControl = this.grSales;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Касса";
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.gridColumn2);
            this.gridBand1.Columns.Add(this.gridColumn1);
            this.gridBand1.Columns.Add(this.gridColumn3);
            this.gridBand1.Columns.Add(this.gridColumn8);
            this.gridBand1.Columns.Add(this.gridColumn9);
            this.gridBand1.Columns.Add(this.gridColumn4);
            this.gridBand1.Columns.Add(this.gridColumn5);
            this.gridBand1.Columns.Add(this.gridColumn6);
            this.gridBand1.Columns.Add(this.gridColumn10);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 825;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Тип абонемента";
            this.bandedGridColumn4.FieldName = "AbonementType";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Клиент";
            this.bandedGridColumn2.FieldName = "Name";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Группа расходов";
            this.bandedGridColumn3.FieldName = "ChargeGroupName";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn3.Visible = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Товар/услуга/абонемент";
            this.gridColumn2.FieldName = "Good";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Группа";
            this.gridColumn1.FieldName = "Group";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Цена";
            this.gridColumn3.FieldName = "Cost";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
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
            this.gridColumn9.Caption = "Стоимость";
            this.gridColumn9.FieldName = "Total";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
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
            this.bandedGridColumn1.Caption = "bandedGridColumn1";
            this.bandedGridColumn1.FieldName = "Type";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // sfdExcel
            // 
            this.sfdExcel.FileName = "касса";
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // CtrlMoneyMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grSales);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CtrlMoneyMovement";
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel slblCharges;
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn10;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.Label lblChargesBig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label slblIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tbtnMonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnChoose;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
    }
}
