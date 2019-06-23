namespace FitnessProject.DataForms
{
    partial class FrmAdministrators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrators));
            this.lvAdministrators = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvAdministrators
            // 
            this.lvAdministrators.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAdministrators.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAdministrators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAdministrators.HoverSelection = true;
            this.lvAdministrators.Location = new System.Drawing.Point(0, 0);
            this.lvAdministrators.MultiSelect = false;
            this.lvAdministrators.Name = "lvAdministrators";
            this.lvAdministrators.Size = new System.Drawing.Size(289, 223);
            this.lvAdministrators.TabIndex = 0;
            this.lvAdministrators.UseCompatibleStateImageBehavior = false;
            this.lvAdministrators.View = System.Windows.Forms.View.Details;
            this.lvAdministrators.SelectedIndexChanged += new System.EventHandler(this.lvAdministrators_SelectedIndexChanged);
            this.lvAdministrators.DoubleClick += new System.EventHandler(this.lvAdministrators_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Администраторы";
            this.columnHeader1.Width = 265;
            // 
            // FrmAdministrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.lvAdministrators);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdministrators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администраторы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdministrators;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}