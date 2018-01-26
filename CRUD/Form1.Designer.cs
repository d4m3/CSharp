namespace CRUD
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.chkGender = new MetroFramework.Controls.MetroCheckBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBirthday = new MetroFramework.Controls.MetroTextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(23, 72);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(452, 465);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.htmlLabel6);
            this.pContainer.Controls.Add(this.txtBirthday);
            this.pContainer.Controls.Add(this.htmlLabel4);
            this.pContainer.Controls.Add(this.chkGender);
            this.pContainer.Controls.Add(this.htmlLabel5);
            this.pContainer.Controls.Add(this.htmlLabel3);
            this.pContainer.Controls.Add(this.htmlLabel2);
            this.pContainer.Controls.Add(this.txtAddress);
            this.pContainer.Controls.Add(this.txtEmail);
            this.pContainer.Controls.Add(this.txtFullName);
            this.pContainer.Controls.Add(this.htmlLabel1);
            this.pContainer.Controls.Add(this.btnBrowse);
            this.pContainer.Controls.Add(this.txtStudentID);
            this.pContainer.Controls.Add(this.pic);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(481, 74);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(506, 465);
            this.pContainer.TabIndex = 1;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(20, 17);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(143, 161);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(250, 17);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(239, 23);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(56, 184);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(64, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(169, 17);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 5;
            this.htmlLabel1.Text = "Student ID:";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(59, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(169, 46);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(78, 23);
            this.htmlLabel2.TabIndex = 7;
            this.htmlLabel2.Text = "Fullname:";
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FullName", true));
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(250, 46);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(239, 23);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Email", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(250, 123);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(239, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(41, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(169, 123);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(78, 23);
            this.htmlLabel3.TabIndex = 7;
            this.htmlLabel3.Text = "Email:";
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.studentBindingSource, "Gender", true));
            this.chkGender.Location = new System.Drawing.Point(250, 76);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(38, 15);
            this.chkGender.TabIndex = 8;
            this.chkGender.Text = "???";
            this.chkGender.UseSelectable = true;
            this.chkGender.CheckStateChanged += new System.EventHandler(this.chkGender_CheckStateChanged);
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(50, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(169, 68);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(78, 23);
            this.htmlLabel4.TabIndex = 9;
            this.htmlLabel4.Text = "Gender:";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(250, 152);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(239, 121);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(54, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(169, 152);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(78, 23);
            this.htmlLabel5.TabIndex = 7;
            this.htmlLabel5.Text = "Address:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(909, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(630, 543);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(537, 543);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(723, 543);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(816, 543);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(54, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(169, 95);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(78, 23);
            this.htmlLabel6.TabIndex = 11;
            this.htmlLabel6.Text = "Birthday:";
            // 
            // txtBirthday
            // 
            // 
            // 
            // 
            this.txtBirthday.CustomButton.Image = null;
            this.txtBirthday.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtBirthday.CustomButton.Name = "";
            this.txtBirthday.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirthday.CustomButton.TabIndex = 1;
            this.txtBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirthday.CustomButton.UseSelectable = true;
            this.txtBirthday.CustomButton.Visible = false;
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Birthday", true));
            this.txtBirthday.Lines = new string[0];
            this.txtBirthday.Location = new System.Drawing.Point(250, 95);
            this.txtBirthday.MaxLength = 32767;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PasswordChar = '\0';
            this.txtBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirthday.SelectedText = "";
            this.txtBirthday.SelectionLength = 0;
            this.txtBirthday.SelectionStart = 0;
            this.txtBirthday.ShortcutsEnabled = true;
            this.txtBirthday.Size = new System.Drawing.Size(239, 23);
            this.txtBirthday.TabIndex = 10;
            this.txtBirthday.UseSelectable = true;
            this.txtBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirthday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(CRUD.Student);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private System.Windows.Forms.PictureBox pic;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Controls.MetroCheckBox chkGender;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Controls.MetroTextBox txtBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}

