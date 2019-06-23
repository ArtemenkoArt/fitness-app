namespace FitnessProject.DataForms
{
    partial class FrmEditUser
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditUser));
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tbcUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvAccessLevels = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lbComponents = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbServices = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAbonements = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbConstant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grVisits = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grAdmins = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.tbMassage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFitness = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Время ухода";
            this.bandedGridColumn4.FieldName = "TimeOff";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn4.Visible = true;
            // 
            // tbcUser
            // 
            this.tbcUser.Controls.Add(this.tabPage1);
            this.tbcUser.Controls.Add(this.tabPage2);
            this.tbcUser.Controls.Add(this.tabPage3);
            this.tbcUser.Controls.Add(this.tabPage4);
            this.tbcUser.Controls.Add(this.tabPage5);
            this.tbcUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcUser.Location = new System.Drawing.Point(0, 0);
            this.tbcUser.Name = "tbcUser";
            this.tbcUser.SelectedIndex = 0;
            this.tbcUser.Size = new System.Drawing.Size(605, 323);
            this.tbcUser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbIsAdmin);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbCode);
            this.tabPage1.Controls.Add(this.tbLogin);
            this.tabPage1.Controls.Add(this.tbJobTitle);
            this.tabPage1.Controls.Add(this.tbFIO);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Location = new System.Drawing.Point(12, 199);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(105, 17);
            this.cbIsAdmin.TabIndex = 10;
            this.cbIsAdmin.Text = "Администратор";
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(190, 154);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(225, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(190, 117);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(225, 20);
            this.tbCode.TabIndex = 8;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(190, 82);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(225, 20);
            this.tbLogin.TabIndex = 7;
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Location = new System.Drawing.Point(190, 45);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(225, 20);
            this.tbJobTitle.TabIndex = 6;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(190, 11);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(225, 20);
            this.tbFIO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф.И.О:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvAccessLevels);
            this.tabPage2.Controls.Add(this.lbComponents);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Уровни доступа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvAccessLevels
            // 
            this.lvAccessLevels.CheckBoxes = true;
            this.lvAccessLevels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAccessLevels.Location = new System.Drawing.Point(297, 72);
            this.lvAccessLevels.Name = "lvAccessLevels";
            this.lvAccessLevels.Size = new System.Drawing.Size(161, 212);
            this.lvAccessLevels.TabIndex = 3;
            this.lvAccessLevels.UseCompatibleStateImageBehavior = false;
            this.lvAccessLevels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Уровень";
            // 
            // lbComponents
            // 
            this.lbComponents.FormattingEnabled = true;
            this.lbComponents.Location = new System.Drawing.Point(20, 72);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(157, 212);
            this.lbComponents.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Уровни доступа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Компоненты";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbFitness);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbMassage);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tbServices);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbBar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tbAbonements);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tbConstant);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(597, 297);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ставка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbServices
            // 
            this.tbServices.Location = new System.Drawing.Point(125, 123);
            this.tbServices.Name = "tbServices";
            this.tbServices.Size = new System.Drawing.Size(136, 20);
            this.tbServices.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "% (услуги):";
            // 
            // tbBar
            // 
            this.tbBar.Location = new System.Drawing.Point(125, 87);
            this.tbBar.Name = "tbBar";
            this.tbBar.Size = new System.Drawing.Size(136, 20);
            this.tbBar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "% (бар):";
            // 
            // tbAbonements
            // 
            this.tbAbonements.Location = new System.Drawing.Point(125, 51);
            this.tbAbonements.Name = "tbAbonements";
            this.tbAbonements.Size = new System.Drawing.Size(136, 20);
            this.tbAbonements.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "% (абонементы):";
            // 
            // tbConstant
            // 
            this.tbConstant.Location = new System.Drawing.Point(125, 15);
            this.tbConstant.Name = "tbConstant";
            this.tbConstant.Size = new System.Drawing.Size(136, 20);
            this.tbConstant.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ставка:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grVisits);
            this.tabPage4.Controls.Add(this.toolStrip1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(597, 297);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Входы/выходы из систему";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grVisits
            // 
            this.grVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grVisits.EmbeddedNavigator.Name = "";
            this.grVisits.Location = new System.Drawing.Point(0, 25);
            this.grVisits.MainView = this.advBandedGridView1;
            this.grVisits.Name = "grVisits";
            this.grVisits.Size = new System.Drawing.Size(597, 272);
            this.grVisits.TabIndex = 2;
            this.grVisits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.bandedGridColumn4;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "";
            styleFormatCondition1.Value2 = "";
            this.advBandedGridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.advBandedGridView1.GridControl = this.grVisits;
            this.advBandedGridView1.GroupPanelText = " ";
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Входы в систему персонала";
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 300;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Смена";
            this.bandedGridColumn2.FieldName = "User";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Дата";
            this.bandedGridColumn1.FieldName = "Date";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Время прихода";
            this.bandedGridColumn3.FieldName = "TimeOn";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn3.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grAdmins);
            this.tabPage5.Controls.Add(this.toolStrip2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(597, 297);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Администраторы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grAdmins
            // 
            this.grAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grAdmins.EmbeddedNavigator.Name = "";
            this.grAdmins.Location = new System.Drawing.Point(0, 25);
            this.grAdmins.MainView = this.advBandedGridView2;
            this.grAdmins.Name = "grAdmins";
            this.grAdmins.Size = new System.Drawing.Size(597, 272);
            this.grAdmins.TabIndex = 1;
            this.grAdmins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView2});
            // 
            // advBandedGridView2
            // 
            this.advBandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.advBandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn5,
            this.bandedGridColumn6});
            this.advBandedGridView2.GridControl = this.grAdmins;
            this.advBandedGridView2.GroupPanelText = " ";
            this.advBandedGridView2.Name = "advBandedGridView2";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Администраторы";
            this.gridBand2.Columns.Add(this.bandedGridColumn6);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 349;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Ф.И.О.";
            this.bandedGridColumn6.FieldName = "FIO";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.Width = 349;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "bandedGridColumn5";
            this.bandedGridColumn5.FieldName = "Id";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.tbtnRemove});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(597, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(437, 335);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Files|*.xls";
            // 
            // tbMassage
            // 
            this.tbMassage.Location = new System.Drawing.Point(125, 159);
            this.tbMassage.Name = "tbMassage";
            this.tbMassage.Size = new System.Drawing.Size(136, 20);
            this.tbMassage.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "% (массаж):";
            // 
            // tbFitness
            // 
            this.tbFitness.Location = new System.Drawing.Point(125, 196);
            this.tbFitness.Name = "tbFitness";
            this.tbFitness.Size = new System.Drawing.Size(136, 20);
            this.tbFitness.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "% (аэробика):";
            // 
            // FrmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 368);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbcUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование пользователя";
            this.tbcUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvAccessLevels;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnExcel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private DevExpress.XtraGrid.GridControl grVisits;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripButton tbtnRemove;
        private DevExpress.XtraGrid.GridControl grAdmins;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private System.Windows.Forms.TextBox tbServices;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAbonements;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbConstant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.TextBox tbFitness;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMassage;
        private System.Windows.Forms.Label label12;
    }
}