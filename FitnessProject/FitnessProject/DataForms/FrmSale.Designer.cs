﻿namespace FitnessProject.DataForms
{
    partial class FrmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductGroup = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа товаров:";
            // 
            // cbProductGroup
            // 
            this.cbProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductGroup.FormattingEnabled = true;
            this.cbProductGroup.Location = new System.Drawing.Point(182, 27);
            this.cbProductGroup.Name = "cbProductGroup";
            this.cbProductGroup.Size = new System.Drawing.Size(261, 21);
            this.cbProductGroup.TabIndex = 2;
            this.cbProductGroup.SelectedIndexChanged += new System.EventHandler(this.cbProductGroup_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(182, 64);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(261, 21);
            this.cbProduct.TabIndex = 3;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(463, 72);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(0, 13);
            this.lblDimension.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(182, 109);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(261, 20);
            this.tbQuantity.TabIndex = 6;
            this.tbQuantity.Text = "0";
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantity_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(287, 150);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCost.Location = new System.Drawing.Point(178, 146);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 24);
            this.lblCost.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "К оплате:";
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDimension);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbProductGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа товаров:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProductGroup;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label4;
    }
}