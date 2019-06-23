namespace FitnessProject.Components
{
    partial class CtrlInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAbonement = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWeekdays = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVisitCount = new System.Windows.Forms.Label();
            this.cbSubstitution = new System.Windows.Forms.CheckBox();
            this.cbCoaches = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шкафчик:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(131, 24);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 13);
            this.lblClient.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(131, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(131, 88);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 5;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(32, 391);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Завершить";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Абонемент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Инструктор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Время:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дни недели:";
            // 
            // lblAbonement
            // 
            this.lblAbonement.AutoSize = true;
            this.lblAbonement.Location = new System.Drawing.Point(155, 125);
            this.lblAbonement.Name = "lblAbonement";
            this.lblAbonement.Size = new System.Drawing.Size(0, 13);
            this.lblAbonement.TabIndex = 11;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(155, 160);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(0, 13);
            this.lblCoach.TabIndex = 12;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(155, 198);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 13;
            // 
            // lblWeekdays
            // 
            this.lblWeekdays.AutoSize = true;
            this.lblWeekdays.Location = new System.Drawing.Point(155, 232);
            this.lblWeekdays.Name = "lblWeekdays";
            this.lblWeekdays.Size = new System.Drawing.Size(0, 13);
            this.lblWeekdays.TabIndex = 14;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(461, 24);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(212, 221);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 20;
            this.pbPhoto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Количество посещений:";
            // 
            // lblVisitCount
            // 
            this.lblVisitCount.AutoSize = true;
            this.lblVisitCount.Location = new System.Drawing.Point(193, 273);
            this.lblVisitCount.Name = "lblVisitCount";
            this.lblVisitCount.Size = new System.Drawing.Size(0, 13);
            this.lblVisitCount.TabIndex = 22;
            // 
            // cbSubstitution
            // 
            this.cbSubstitution.AutoSize = true;
            this.cbSubstitution.Location = new System.Drawing.Point(32, 326);
            this.cbSubstitution.Name = "cbSubstitution";
            this.cbSubstitution.Size = new System.Drawing.Size(65, 17);
            this.cbSubstitution.TabIndex = 23;
            this.cbSubstitution.Text = "Замена";
            this.cbSubstitution.UseVisualStyleBackColor = true;
            this.cbSubstitution.Visible = false;
            this.cbSubstitution.CheckedChanged += new System.EventHandler(this.cbSubstitution_CheckedChanged);
            // 
            // cbCoaches
            // 
            this.cbCoaches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoaches.FormattingEnabled = true;
            this.cbCoaches.Location = new System.Drawing.Point(32, 322);
            this.cbCoaches.Name = "cbCoaches";
            this.cbCoaches.Size = new System.Drawing.Size(228, 21);
            this.cbCoaches.TabIndex = 24;
            // 
            // CtrlInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCoaches);
            this.Controls.Add(this.cbSubstitution);
            this.Controls.Add(this.lblVisitCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblWeekdays);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.lblAbonement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CtrlInfo";
            this.Size = new System.Drawing.Size(879, 523);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAbonement;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWeekdays;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVisitCount;
        private System.Windows.Forms.CheckBox cbSubstitution;
        private System.Windows.Forms.ComboBox cbCoaches;
    }
}
