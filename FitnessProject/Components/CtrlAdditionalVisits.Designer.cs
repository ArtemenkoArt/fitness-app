namespace FitnessProject.Components
{
    partial class CtrlAdditionalVisits
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
            this.btnNext = new System.Windows.Forms.Button();
            this.cbWithout = new System.Windows.Forms.CheckBox();
            this.gbWithoutCard = new System.Windows.Forms.GroupBox();
            this.cbLeave = new System.Windows.Forms.CheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblVisitsLabel = new System.Windows.Forms.Label();
            this.lblVisitsCount = new System.Windows.Forms.Label();
            this.lblMyVisitsCount = new System.Windows.Forms.Label();
            this.lblMyVisits = new System.Windows.Forms.Label();
            this.btnVisit = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAbonement = new System.Windows.Forms.Label();
            this.gbWithoutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(575, 190);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbWithout
            // 
            this.cbWithout.AutoSize = true;
            this.cbWithout.Location = new System.Drawing.Point(244, 196);
            this.cbWithout.Name = "cbWithout";
            this.cbWithout.Size = new System.Drawing.Size(94, 17);
            this.cbWithout.TabIndex = 6;
            this.cbWithout.Text = "Без карточки";
            this.cbWithout.UseVisualStyleBackColor = true;
            this.cbWithout.CheckedChanged += new System.EventHandler(this.cbWithout_CheckedChanged);
            // 
            // gbWithoutCard
            // 
            this.gbWithoutCard.Controls.Add(this.cbLeave);
            this.gbWithoutCard.Controls.Add(this.gridControl1);
            this.gbWithoutCard.Controls.Add(this.label1);
            this.gbWithoutCard.Controls.Add(this.tbFIO);
            this.gbWithoutCard.Controls.Add(this.btnView);
            this.gbWithoutCard.Location = new System.Drawing.Point(244, 232);
            this.gbWithoutCard.Name = "gbWithoutCard";
            this.gbWithoutCard.Size = new System.Drawing.Size(422, 251);
            this.gbWithoutCard.TabIndex = 5;
            this.gbWithoutCard.TabStop = false;
            this.gbWithoutCard.Text = "Без карточки";
            // 
            // cbLeave
            // 
            this.cbLeave.AutoSize = true;
            this.cbLeave.Location = new System.Drawing.Point(190, 26);
            this.cbLeave.Name = "cbLeave";
            this.cbLeave.Size = new System.Drawing.Size(51, 17);
            this.cbLeave.TabIndex = 3;
            this.cbLeave.Text = "Уход";
            this.cbLeave.UseVisualStyleBackColor = true;
            this.cbLeave.CheckedChanged += new System.EventHandler(this.cbLeave_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 104);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 141);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Клиенты";
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 75;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Ф.И.О.";
            this.bandedGridColumn2.FieldName = "FIO";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Id";
            this.bandedGridColumn1.FieldName = "Id";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ф.И.О.:";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(156, 66);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(260, 20);
            this.tbFIO.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(11, 20);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Просмотр";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(244, 153);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(424, 20);
            this.tbBarcode.TabIndex = 4;
            // 
            // lblVisitsLabel
            // 
            this.lblVisitsLabel.AutoSize = true;
            this.lblVisitsLabel.Location = new System.Drawing.Point(716, 160);
            this.lblVisitsLabel.Name = "lblVisitsLabel";
            this.lblVisitsLabel.Size = new System.Drawing.Size(69, 13);
            this.lblVisitsLabel.TabIndex = 8;
            this.lblVisitsLabel.Text = "Посещения:";
            this.lblVisitsLabel.Visible = false;
            // 
            // lblVisitsCount
            // 
            this.lblVisitsCount.AutoSize = true;
            this.lblVisitsCount.Location = new System.Drawing.Point(872, 160);
            this.lblVisitsCount.Name = "lblVisitsCount";
            this.lblVisitsCount.Size = new System.Drawing.Size(0, 13);
            this.lblVisitsCount.TabIndex = 9;
            this.lblVisitsCount.Visible = false;
            // 
            // lblMyVisitsCount
            // 
            this.lblMyVisitsCount.AutoSize = true;
            this.lblMyVisitsCount.Location = new System.Drawing.Point(716, 195);
            this.lblMyVisitsCount.Name = "lblMyVisitsCount";
            this.lblMyVisitsCount.Size = new System.Drawing.Size(112, 13);
            this.lblMyVisitsCount.TabIndex = 10;
            this.lblMyVisitsCount.Text = "Остаток посещений:";
            this.lblMyVisitsCount.Visible = false;
            // 
            // lblMyVisits
            // 
            this.lblMyVisits.AutoSize = true;
            this.lblMyVisits.Location = new System.Drawing.Point(872, 195);
            this.lblMyVisits.Name = "lblMyVisits";
            this.lblMyVisits.Size = new System.Drawing.Size(0, 13);
            this.lblMyVisits.TabIndex = 11;
            this.lblMyVisits.Visible = false;
            // 
            // btnVisit
            // 
            this.btnVisit.Location = new System.Drawing.Point(719, 232);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(75, 23);
            this.btnVisit.TabIndex = 12;
            this.btnVisit.Text = "Посещение";
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Visible = false;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.Location = new System.Drawing.Point(31, 39);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 24);
            this.lblClient.TabIndex = 13;
            // 
            // lblAbonement
            // 
            this.lblAbonement.AutoSize = true;
            this.lblAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbonement.Location = new System.Drawing.Point(31, 98);
            this.lblAbonement.Name = "lblAbonement";
            this.lblAbonement.Size = new System.Drawing.Size(0, 24);
            this.lblAbonement.TabIndex = 14;
            // 
            // CtrlAdditionalVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAbonement);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.lblMyVisits);
            this.Controls.Add(this.lblMyVisitsCount);
            this.Controls.Add(this.lblVisitsCount);
            this.Controls.Add(this.lblVisitsLabel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbWithout);
            this.Controls.Add(this.gbWithoutCard);
            this.Controls.Add(this.tbBarcode);
            this.Name = "CtrlAdditionalVisits";
            this.Size = new System.Drawing.Size(1031, 489);
            this.gbWithoutCard.ResumeLayout(false);
            this.gbWithoutCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbWithout;
        private System.Windows.Forms.GroupBox gbWithoutCard;
        private System.Windows.Forms.CheckBox cbLeave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lblVisitsLabel;
        private System.Windows.Forms.Label lblVisitsCount;
        private System.Windows.Forms.Label lblMyVisitsCount;
        private System.Windows.Forms.Label lblMyVisits;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAbonement;
    }
}
