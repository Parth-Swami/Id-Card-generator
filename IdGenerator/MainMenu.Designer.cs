namespace IdGenerator
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRowNumber = new System.Windows.Forms.TextBox();
            this.metroLinkUpdate = new MetroFramework.Controls.MetroLink();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateDate = new MetroFramework.Controls.MetroDateTime();
            this.txtUpdateNatId = new MetroFramework.Controls.MetroTextBox();
            this.txtUpdateFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.AddDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAddNationalId = new MetroFramework.Controls.MetroTextBox();
            this.txtAddName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metroToggleDate = new MetroFramework.Controls.MetroToggle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblShortDate = new System.Windows.Forms.Label();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.lblShape = new System.Windows.Forms.Label();
            this.lblFrameColor = new System.Windows.Forms.Label();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioNone = new MetroFramework.Controls.MetroRadioButton();
            this.radioRounded = new MetroFramework.Controls.MetroRadioButton();
            this.radioBoxed = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBoxTextColor = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroComboBoxFrameColor = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBoxTheme = new System.Windows.Forms.PictureBox();
            this.btnSaveTheme = new MetroFramework.Controls.MetroButton();
            this.backButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRowNumber);
            this.groupBox1.Controls.Add(this.metroLinkUpdate);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.updateDate);
            this.groupBox1.Controls.Add(this.txtUpdateNatId);
            this.groupBox1.Controls.Add(this.txtUpdateFullName);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(256, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // textRowNumber
            // 
            this.textRowNumber.Location = new System.Drawing.Point(99, 187);
            this.textRowNumber.Name = "textRowNumber";
            this.textRowNumber.Size = new System.Drawing.Size(189, 20);
            this.textRowNumber.TabIndex = 11;
            // 
            // metroLinkUpdate
            // 
            this.metroLinkUpdate.Location = new System.Drawing.Point(196, 151);
            this.metroLinkUpdate.Name = "metroLinkUpdate";
            this.metroLinkUpdate.Size = new System.Drawing.Size(93, 23);
            this.metroLinkUpdate.TabIndex = 10;
            this.metroLinkUpdate.Text = "Update Image";
            this.metroLinkUpdate.UseSelectable = true;
            this.metroLinkUpdate.Click += new System.EventHandler(this.metroLinkUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // updateDate
            // 
            this.updateDate.CustomFormat = "dd-MM-yyyy";
            this.updateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateDate.Location = new System.Drawing.Point(96, 328);
            this.updateDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.updateDate.Name = "updateDate";
            this.updateDate.Size = new System.Drawing.Size(200, 29);
            this.updateDate.TabIndex = 7;
            // 
            // txtUpdateNatId
            // 
            // 
            // 
            // 
            this.txtUpdateNatId.CustomButton.Image = null;
            this.txtUpdateNatId.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtUpdateNatId.CustomButton.Name = "";
            this.txtUpdateNatId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUpdateNatId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUpdateNatId.CustomButton.TabIndex = 1;
            this.txtUpdateNatId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUpdateNatId.CustomButton.UseSelectable = true;
            this.txtUpdateNatId.CustomButton.Visible = false;
            this.txtUpdateNatId.Lines = new string[0];
            this.txtUpdateNatId.Location = new System.Drawing.Point(93, 281);
            this.txtUpdateNatId.MaxLength = 32767;
            this.txtUpdateNatId.Name = "txtUpdateNatId";
            this.txtUpdateNatId.PasswordChar = '\0';
            this.txtUpdateNatId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUpdateNatId.SelectedText = "";
            this.txtUpdateNatId.SelectionLength = 0;
            this.txtUpdateNatId.SelectionStart = 0;
            this.txtUpdateNatId.ShortcutsEnabled = true;
            this.txtUpdateNatId.Size = new System.Drawing.Size(203, 23);
            this.txtUpdateNatId.TabIndex = 6;
            this.txtUpdateNatId.UseSelectable = true;
            this.txtUpdateNatId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUpdateNatId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUpdateFullName
            // 
            // 
            // 
            // 
            this.txtUpdateFullName.CustomButton.Image = null;
            this.txtUpdateFullName.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtUpdateFullName.CustomButton.Name = "";
            this.txtUpdateFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUpdateFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUpdateFullName.CustomButton.TabIndex = 1;
            this.txtUpdateFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUpdateFullName.CustomButton.UseSelectable = true;
            this.txtUpdateFullName.CustomButton.Visible = false;
            this.txtUpdateFullName.Lines = new string[0];
            this.txtUpdateFullName.Location = new System.Drawing.Point(93, 225);
            this.txtUpdateFullName.MaxLength = 32767;
            this.txtUpdateFullName.Name = "txtUpdateFullName";
            this.txtUpdateFullName.PasswordChar = '\0';
            this.txtUpdateFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUpdateFullName.SelectedText = "";
            this.txtUpdateFullName.SelectionLength = 0;
            this.txtUpdateFullName.SelectionStart = 0;
            this.txtUpdateFullName.ShortcutsEnabled = true;
            this.txtUpdateFullName.Size = new System.Drawing.Size(203, 23);
            this.txtUpdateFullName.TabIndex = 5;
            this.txtUpdateFullName.UseSelectable = true;
            this.txtUpdateFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUpdateFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 328);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 281);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "SRN ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 223);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Full Name ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Details";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(35, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 34);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(10, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 335);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(225, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(571, 68);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(381, 369);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLink1);
            this.metroTabPage1.Controls.Add(this.AddDatePicker);
            this.metroTabPage1.Controls.Add(this.btnAdd);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtAddNationalId);
            this.metroTabPage1.Controls.Add(this.txtAddName);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(373, 327);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add New Record";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(94, 109);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(220, 23);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "Click Here To Select User Image";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // AddDatePicker
            // 
            this.AddDatePicker.CustomFormat = "dd-MM-yyyy";
            this.AddDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddDatePicker.Location = new System.Drawing.Point(111, 206);
            this.AddDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.AddDatePicker.Name = "AddDatePicker";
            this.AddDatePicker.Size = new System.Drawing.Size(200, 29);
            this.AddDatePicker.TabIndex = 7;
            this.AddDatePicker.Value = new System.DateTime(2016, 11, 3, 20, 27, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Record  Details";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Date OF Birth";
            // 
            // txtAddNationalId
            // 
            // 
            // 
            // 
            this.txtAddNationalId.CustomButton.Image = null;
            this.txtAddNationalId.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtAddNationalId.CustomButton.Name = "";
            this.txtAddNationalId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddNationalId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddNationalId.CustomButton.TabIndex = 1;
            this.txtAddNationalId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddNationalId.CustomButton.UseSelectable = true;
            this.txtAddNationalId.CustomButton.Visible = false;
            this.txtAddNationalId.Lines = new string[] {
        "srn"};
            this.txtAddNationalId.Location = new System.Drawing.Point(111, 156);
            this.txtAddNationalId.MaxLength = 32767;
            this.txtAddNationalId.Name = "txtAddNationalId";
            this.txtAddNationalId.PasswordChar = '\0';
            this.txtAddNationalId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddNationalId.SelectedText = "";
            this.txtAddNationalId.SelectionLength = 0;
            this.txtAddNationalId.SelectionStart = 0;
            this.txtAddNationalId.ShortcutsEnabled = true;
            this.txtAddNationalId.Size = new System.Drawing.Size(203, 23);
            this.txtAddNationalId.TabIndex = 6;
            this.txtAddNationalId.Text = "srn";
            this.txtAddNationalId.UseSelectable = true;
            this.txtAddNationalId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddNationalId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddName
            // 
            // 
            // 
            // 
            this.txtAddName.CustomButton.Image = null;
            this.txtAddName.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtAddName.CustomButton.Name = "";
            this.txtAddName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddName.CustomButton.TabIndex = 1;
            this.txtAddName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddName.CustomButton.UseSelectable = true;
            this.txtAddName.CustomButton.Visible = false;
            this.txtAddName.Lines = new string[0];
            this.txtAddName.Location = new System.Drawing.Point(111, 66);
            this.txtAddName.MaxLength = 32767;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.PasswordChar = '\0';
            this.txtAddName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddName.SelectedText = "";
            this.txtAddName.SelectionLength = 0;
            this.txtAddName.SelectionStart = 0;
            this.txtAddName.ShortcutsEnabled = true;
            this.txtAddName.Size = new System.Drawing.Size(203, 23);
            this.txtAddName.TabIndex = 5;
            this.txtAddName.UseSelectable = true;
            this.txtAddName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "SRN ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 66);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Full Name ";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox6);
            this.metroTabPage2.Controls.Add(this.groupBox5);
            this.metroTabPage2.Controls.Add(this.btnUpdateSettings);
            this.metroTabPage2.Controls.Add(this.groupBox4);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(373, 327);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.metroToggleDate);
            this.groupBox6.Location = new System.Drawing.Point(3, 213);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 67);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Long Date";
            // 
            // metroToggleDate
            // 
            this.metroToggleDate.AutoSize = true;
            this.metroToggleDate.Location = new System.Drawing.Point(17, 32);
            this.metroToggleDate.Name = "metroToggleDate";
            this.metroToggleDate.Size = new System.Drawing.Size(80, 17);
            this.metroToggleDate.TabIndex = 0;
            this.metroToggleDate.Text = "Off";
            this.metroToggleDate.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblShortDate);
            this.groupBox5.Controls.Add(this.lblTextColor);
            this.groupBox5.Controls.Add(this.lblShape);
            this.groupBox5.Controls.Add(this.lblFrameColor);
            this.groupBox5.Location = new System.Drawing.Point(152, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 120);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Settings";
            // 
            // lblShortDate
            // 
            this.lblShortDate.AutoSize = true;
            this.lblShortDate.Location = new System.Drawing.Point(12, 100);
            this.lblShortDate.Name = "lblShortDate";
            this.lblShortDate.Size = new System.Drawing.Size(75, 13);
            this.lblShortDate.TabIndex = 3;
            this.lblShortDate.Text = "Is Date Short :";
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Location = new System.Drawing.Point(9, 74);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(55, 13);
            this.lblTextColor.TabIndex = 2;
            this.lblTextColor.Text = "Text Color";
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(9, 48);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(70, 13);
            this.lblShape.TabIndex = 1;
            this.lblShape.Text = "Frame Shape";
            // 
            // lblFrameColor
            // 
            this.lblFrameColor.AutoSize = true;
            this.lblFrameColor.Location = new System.Drawing.Point(9, 16);
            this.lblFrameColor.Name = "lblFrameColor";
            this.lblFrameColor.Size = new System.Drawing.Size(69, 13);
            this.lblFrameColor.TabIndex = 0;
            this.lblFrameColor.Text = "Frame Color :";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(108, 286);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(123, 38);
            this.btnUpdateSettings.TabIndex = 4;
            this.btnUpdateSettings.Text = "Update Settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioNone);
            this.groupBox4.Controls.Add(this.radioRounded);
            this.groupBox4.Controls.Add(this.radioBoxed);
            this.groupBox4.Location = new System.Drawing.Point(3, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 120);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture Frame Shape";
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(7, 99);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(68, 15);
            this.radioNone.TabIndex = 2;
            this.radioNone.Text = "noframe";
            this.radioNone.UseSelectable = true;
            // 
            // radioRounded
            // 
            this.radioRounded.AutoSize = true;
            this.radioRounded.Location = new System.Drawing.Point(7, 64);
            this.radioRounded.Name = "radioRounded";
            this.radioRounded.Size = new System.Drawing.Size(55, 15);
            this.radioRounded.TabIndex = 1;
            this.radioRounded.Text = "round";
            this.radioRounded.UseSelectable = true;
            // 
            // radioBoxed
            // 
            this.radioBoxed.AutoSize = true;
            this.radioBoxed.Location = new System.Drawing.Point(7, 32);
            this.radioBoxed.Name = "radioBoxed";
            this.radioBoxed.Size = new System.Drawing.Size(42, 15);
            this.radioBoxed.TabIndex = 0;
            this.radioBoxed.Text = "box";
            this.radioBoxed.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBoxTextColor);
            this.groupBox3.Location = new System.Drawing.Point(162, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Color";
            // 
            // metroComboBoxTextColor
            // 
            this.metroComboBoxTextColor.FormattingEnabled = true;
            this.metroComboBoxTextColor.ItemHeight = 23;
            this.metroComboBoxTextColor.Items.AddRange(new object[] {
            "orange",
            "red",
            "green",
            "blue"});
            this.metroComboBoxTextColor.Location = new System.Drawing.Point(25, 29);
            this.metroComboBoxTextColor.Name = "metroComboBoxTextColor";
            this.metroComboBoxTextColor.Size = new System.Drawing.Size(138, 29);
            this.metroComboBoxTextColor.TabIndex = 0;
            this.metroComboBoxTextColor.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroComboBoxFrameColor);
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture Frame  Color";
            // 
            // metroComboBoxFrameColor
            // 
            this.metroComboBoxFrameColor.FormattingEnabled = true;
            this.metroComboBoxFrameColor.ItemHeight = 23;
            this.metroComboBoxFrameColor.Items.AddRange(new object[] {
            "orange",
            "red",
            "green",
            "blue"});
            this.metroComboBoxFrameColor.Location = new System.Drawing.Point(7, 29);
            this.metroComboBoxFrameColor.Name = "metroComboBoxFrameColor";
            this.metroComboBoxFrameColor.Size = new System.Drawing.Size(130, 29);
            this.metroComboBoxFrameColor.TabIndex = 0;
            this.metroComboBoxFrameColor.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.linkLabel1);
            this.metroTabPage3.Controls.Add(this.btnPrint);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(373, 327);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Print";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(163, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Select Theme Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(121, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 89);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Pdf";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.pictureBoxTheme);
            this.metroTabPage4.Controls.Add(this.btnSaveTheme);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(373, 327);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Get Theme Edit";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // pictureBoxTheme
            // 
            this.pictureBoxTheme.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTheme.Image")));
            this.pictureBoxTheme.Location = new System.Drawing.Point(4, 20);
            this.pictureBoxTheme.Name = "pictureBoxTheme";
            this.pictureBoxTheme.Size = new System.Drawing.Size(354, 229);
            this.pictureBoxTheme.TabIndex = 6;
            this.pictureBoxTheme.TabStop = false;
            // 
            // btnSaveTheme
            // 
            this.btnSaveTheme.Location = new System.Drawing.Point(94, 297);
            this.btnSaveTheme.Name = "btnSaveTheme";
            this.btnSaveTheme.Size = new System.Drawing.Size(154, 34);
            this.btnSaveTheme.TabIndex = 2;
            this.btnSaveTheme.Text = "Id Theme";
            this.btnSaveTheme.UseSelectable = true;
            this.btnSaveTheme.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(733, 439);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(106, 34);
            this.backButton1.TabIndex = 6;
            this.backButton1.Text = "Back";
            this.backButton1.UseSelectable = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 540);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "ID-Card Generator";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUpdateFullName;
        private MetroFramework.Controls.MetroTextBox txtUpdateNatId;
        private MetroFramework.Controls.MetroDateTime updateDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLink metroLinkUpdate;
        private System.Windows.Forms.TextBox textRowNumber;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroDateTime AddDatePicker;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAddNationalId;
        private MetroFramework.Controls.MetroTextBox txtAddName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblFrameColor;
        private System.Windows.Forms.Button btnUpdateSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton radioNone;
        private MetroFramework.Controls.MetroRadioButton radioRounded;
        private MetroFramework.Controls.MetroRadioButton radioBoxed;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTextColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFrameColor;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroToggle metroToggleDate;
        private System.Windows.Forms.Label lblShortDate;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroButton btnSaveTheme;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxTheme;
        private MetroFramework.Controls.MetroButton backButton1;
    }
}

