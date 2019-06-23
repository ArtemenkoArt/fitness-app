namespace FitnessProject.ServiceForms
{
    partial class FrmSelectAbonement
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
            this.rbAero = new System.Windows.Forms.RadioButton();
            this.rbFitness = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lvAbonements = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rbAero
            // 
            this.rbAero.AutoSize = true;
            this.rbAero.Location = new System.Drawing.Point(161, 12);
            this.rbAero.Name = "rbAero";
            this.rbAero.Size = new System.Drawing.Size(97, 17);
            this.rbAero.TabIndex = 2;
            this.rbAero.Text = "Аэробный зал";
            this.rbAero.UseVisualStyleBackColor = true;
            this.rbAero.CheckedChanged += new System.EventHandler(this.rbAero_CheckedChanged);
            // 
            // rbFitness
            // 
            this.rbFitness.AutoSize = true;
            this.rbFitness.Checked = true;
            this.rbFitness.Location = new System.Drawing.Point(21, 12);
            this.rbFitness.Name = "rbFitness";
            this.rbFitness.Size = new System.Drawing.Size(117, 17);
            this.rbFitness.TabIndex = 1;
            this.rbFitness.TabStop = true;
            this.rbFitness.Text = "Тренажерный зал";
            this.rbFitness.UseVisualStyleBackColor = true;
            this.rbFitness.CheckedChanged += new System.EventHandler(this.rbFitness_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(161, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 20);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lvAbonements
            // 
            this.lvAbonements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAbonements.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvAbonements.Location = new System.Drawing.Point(0, 82);
            this.lvAbonements.Name = "lvAbonements";
            this.lvAbonements.Size = new System.Drawing.Size(601, 179);
            this.lvAbonements.TabIndex = 52;
            this.lvAbonements.UseCompatibleStateImageBehavior = false;
            this.lvAbonements.View = System.Windows.Forms.View.Details;
            this.lvAbonements.DoubleClick += new System.EventHandler(this.lvAbonements_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Абонемент";
            this.columnHeader1.Width = 538;
            // 
            // FrmSelectAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.lvAbonements);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbAero);
            this.Controls.Add(this.rbFitness);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectAbonement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор абонемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAero;
        private System.Windows.Forms.RadioButton rbFitness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView lvAbonements;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}