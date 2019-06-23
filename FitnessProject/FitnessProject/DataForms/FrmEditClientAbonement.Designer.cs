namespace FitnessProject.DataForms
{
    partial class FrmEditClientAbonement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditClientAbonement));
            this.btnStartDate = new System.Windows.Forms.Button();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinishDate = new System.Windows.Forms.Button();
            this.tbFinishDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAbonement = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbFitness = new System.Windows.Forms.RadioButton();
            this.rbAero = new System.Windows.Forms.RadioButton();
            this.tbWeekdays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCoach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartDate
            // 
            this.btnStartDate.Location = new System.Drawing.Point(321, 71);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.Size = new System.Drawing.Size(35, 23);
            this.btnStartDate.TabIndex = 3;
            this.btnStartDate.Text = "...";
            this.btnStartDate.UseVisualStyleBackColor = true;
            this.btnStartDate.Click += new System.EventHandler(this.btnStartDate_Click);
            // 
            // tbStartDate
            // 
            this.tbStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbStartDate.Location = new System.Drawing.Point(153, 73);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.ReadOnly = true;
            this.tbStartDate.Size = new System.Drawing.Size(171, 20);
            this.tbStartDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Дата начала:";
            // 
            // btnFinishDate
            // 
            this.btnFinishDate.Location = new System.Drawing.Point(321, 108);
            this.btnFinishDate.Name = "btnFinishDate";
            this.btnFinishDate.Size = new System.Drawing.Size(35, 23);
            this.btnFinishDate.TabIndex = 5;
            this.btnFinishDate.Text = "...";
            this.btnFinishDate.UseVisualStyleBackColor = true;
            this.btnFinishDate.Click += new System.EventHandler(this.btnFinishDate_Click);
            // 
            // tbFinishDate
            // 
            this.tbFinishDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbFinishDate.Location = new System.Drawing.Point(153, 110);
            this.tbFinishDate.Name = "tbFinishDate";
            this.tbFinishDate.ReadOnly = true;
            this.tbFinishDate.Size = new System.Drawing.Size(171, 20);
            this.tbFinishDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Дата окончания:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Абонемент:";
            // 
            // cbAbonement
            // 
            this.cbAbonement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonement.FormattingEnabled = true;
            this.cbAbonement.Location = new System.Drawing.Point(153, 43);
            this.cbAbonement.Name = "cbAbonement";
            this.cbAbonement.Size = new System.Drawing.Size(203, 21);
            this.cbAbonement.TabIndex = 1;
            this.cbAbonement.SelectedIndexChanged += new System.EventHandler(this.cbAbonement_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(200, 263);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 70;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbFitness
            // 
            this.rbFitness.AutoSize = true;
            this.rbFitness.Checked = true;
            this.rbFitness.Location = new System.Drawing.Point(13, 12);
            this.rbFitness.Name = "rbFitness";
            this.rbFitness.Size = new System.Drawing.Size(117, 17);
            this.rbFitness.TabIndex = 48;
            this.rbFitness.TabStop = true;
            this.rbFitness.Text = "Тренажерный зал";
            this.rbFitness.UseVisualStyleBackColor = true;
            this.rbFitness.CheckedChanged += new System.EventHandler(this.rbFitness_CheckedChanged);
            // 
            // rbAero
            // 
            this.rbAero.AutoSize = true;
            this.rbAero.Location = new System.Drawing.Point(153, 12);
            this.rbAero.Name = "rbAero";
            this.rbAero.Size = new System.Drawing.Size(97, 17);
            this.rbAero.TabIndex = 49;
            this.rbAero.Text = "Аэробный зал";
            this.rbAero.UseVisualStyleBackColor = true;
            this.rbAero.CheckedChanged += new System.EventHandler(this.rbAero_CheckedChanged);
            // 
            // tbWeekdays
            // 
            this.tbWeekdays.Location = new System.Drawing.Point(130, 210);
            this.tbWeekdays.Multiline = true;
            this.tbWeekdays.Name = "tbWeekdays";
            this.tbWeekdays.Size = new System.Drawing.Size(226, 47);
            this.tbWeekdays.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Дни недели:";
            // 
            // cbCoach
            // 
            this.cbCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoach.FormattingEnabled = true;
            this.cbCoach.Location = new System.Drawing.Point(130, 178);
            this.cbCoach.Name = "cbCoach";
            this.cbCoach.Size = new System.Drawing.Size(226, 21);
            this.cbCoach.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Тренер:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(130, 147);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(226, 20);
            this.tbTime.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Время:";
            // 
            // FrmEditClientAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 293);
            this.Controls.Add(this.tbWeekdays);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCoach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbAero);
            this.Controls.Add(this.rbFitness);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbAbonement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinishDate);
            this.Controls.Add(this.tbFinishDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditClientAbonement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование абонемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinishDate;
        private System.Windows.Forms.TextBox tbFinishDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAbonement;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbFitness;
        private System.Windows.Forms.RadioButton rbAero;
        private System.Windows.Forms.TextBox tbWeekdays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCoach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label7;
    }
}