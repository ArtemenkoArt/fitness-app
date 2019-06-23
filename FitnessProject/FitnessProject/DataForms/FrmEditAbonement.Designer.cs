namespace FitnessProject.DataForms
{
    partial class FrmEditAbonement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAbonement));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbAdditionalVisits = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWeekdays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCoach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUnlim = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSingle = new System.Windows.Forms.CheckBox();
            this.tbLessonsCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlAbonementType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grPrices = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(195, 427);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(366, 421);
            this.tbcMain.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbAdditionalVisits);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbWeekdays);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbCoach);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbTime);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbUnlim);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbSingle);
            this.tabPage1.Controls.Add(this.tbLessonsCount);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ddlAbonementType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbTotalCost);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbLength);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbAdditionalVisits
            // 
            this.tbAdditionalVisits.Location = new System.Drawing.Point(191, 357);
            this.tbAdditionalVisits.Name = "tbAdditionalVisits";
            this.tbAdditionalVisits.Size = new System.Drawing.Size(159, 20);
            this.tbAdditionalVisits.TabIndex = 33;
            this.tbAdditionalVisits.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Дополнительные посещения:";
            // 
            // tbWeekdays
            // 
            this.tbWeekdays.Location = new System.Drawing.Point(124, 304);
            this.tbWeekdays.Multiline = true;
            this.tbWeekdays.Name = "tbWeekdays";
            this.tbWeekdays.Size = new System.Drawing.Size(226, 47);
            this.tbWeekdays.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Дни недели:";
            // 
            // cbCoach
            // 
            this.cbCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoach.FormattingEnabled = true;
            this.cbCoach.Location = new System.Drawing.Point(124, 272);
            this.cbCoach.Name = "cbCoach";
            this.cbCoach.Size = new System.Drawing.Size(226, 21);
            this.cbCoach.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Тренер:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(124, 241);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(226, 20);
            this.tbTime.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Время:";
            // 
            // cbUnlim
            // 
            this.cbUnlim.AutoSize = true;
            this.cbUnlim.Location = new System.Drawing.Point(19, 17);
            this.cbUnlim.Name = "cbUnlim";
            this.cbUnlim.Size = new System.Drawing.Size(96, 17);
            this.cbUnlim.TabIndex = 25;
            this.cbUnlim.Text = "Безлимитный";
            this.cbUnlim.UseVisualStyleBackColor = true;
            this.cbUnlim.CheckedChanged += new System.EventHandler(this.cbUnlim_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Тип:";
            this.label6.Visible = false;
            // 
            // cbSingle
            // 
            this.cbSingle.AutoSize = true;
            this.cbSingle.Location = new System.Drawing.Point(19, 210);
            this.cbSingle.Name = "cbSingle";
            this.cbSingle.Size = new System.Drawing.Size(71, 17);
            this.cbSingle.TabIndex = 22;
            this.cbSingle.Text = "Разовый";
            this.cbSingle.UseVisualStyleBackColor = true;
            this.cbSingle.CheckedChanged += new System.EventHandler(this.cbSingle_CheckedChanged);
            // 
            // tbLessonsCount
            // 
            this.tbLessonsCount.Location = new System.Drawing.Point(184, 174);
            this.tbLessonsCount.Name = "tbLessonsCount";
            this.tbLessonsCount.Size = new System.Drawing.Size(166, 20);
            this.tbLessonsCount.TabIndex = 18;
            this.tbLessonsCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Количество занятий:";
            // 
            // ddlAbonementType
            // 
            this.ddlAbonementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAbonementType.FormattingEnabled = true;
            this.ddlAbonementType.Items.AddRange(new object[] {
            "Тренажерный зал",
            "Аэробный зал"});
            this.ddlAbonementType.Location = new System.Drawing.Point(124, 39);
            this.ddlAbonementType.Name = "ddlAbonementType";
            this.ddlAbonementType.Size = new System.Drawing.Size(226, 21);
            this.ddlAbonementType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тип абонемента:";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(124, 142);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(226, 20);
            this.tbTotalCost.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Общая стоимость:";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(154, 107);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(196, 20);
            this.tbLength.TabIndex = 15;
            this.tbLength.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Длительность (мес.):";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(226, 20);
            this.tbName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grPrices);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Динамика цены";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grPrices
            // 
            this.grPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPrices.Location = new System.Drawing.Point(3, 28);
            this.grPrices.MainView = this.advBandedGridView1;
            this.grPrices.Name = "grPrices";
            this.grPrices.Size = new System.Drawing.Size(352, 364);
            this.grPrices.TabIndex = 6;
            this.grPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4});
            this.advBandedGridView1.GridControl = this.grPrices;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Динамика изменения цены";
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 358;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Дата начала";
            this.bandedGridColumn3.FieldName = "DateStart";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.Width = 141;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Дата окончания";
            this.bandedGridColumn4.FieldName = "DateFinish";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.Width = 142;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Стоимость";
            this.bandedGridColumn2.FieldName = "Price";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Id";
            this.bandedGridColumn1.FieldName = "Id";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.tbtnEdit,
            this.tbtnRemove,
            this.toolStripSeparator1,
            this.tbtnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(352, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // FrmEditAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 462);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditAbonement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование абонемента";
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbSingle;
        private System.Windows.Forms.TextBox tbLessonsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlAbonementType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl grPrices;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripButton tbtnEdit;
        private System.Windows.Forms.ToolStripButton tbtnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbUnlim;
        private System.Windows.Forms.ComboBox cbCoach;
        private System.Windows.Forms.TextBox tbWeekdays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAdditionalVisits;
        private System.Windows.Forms.Label label10;
    }
}