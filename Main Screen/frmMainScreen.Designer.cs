namespace Student_Manager.Main_Screen
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStaffLog = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.lapLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgStudents = new System.Windows.Forms.DataGridView();
            this.StudentImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lapTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.Label();
            this.txtGreet = new System.Windows.Forms.Label();
            this.btnAddStduent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).BeginInit();
            this.cmStudent.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnStaffLog);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPrograms);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Controls.Add(this.lapLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 676);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnStaffLog
            // 
            this.btnStaffLog.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffLog.FlatAppearance.BorderSize = 0;
            this.btnStaffLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffLog.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStaffLog.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffLog.Image")));
            this.btnStaffLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffLog.Location = new System.Drawing.Point(0, 344);
            this.btnStaffLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStaffLog.Name = "btnStaffLog";
            this.btnStaffLog.Size = new System.Drawing.Size(285, 46);
            this.btnStaffLog.TabIndex = 7;
            this.btnStaffLog.Text = "Staff Log";
            this.btnStaffLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffLog.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(2, 422);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(285, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(-1, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "---------------------------------------------------------------------------";
            // 
            // btnPrograms
            // 
            this.btnPrograms.BackColor = System.Drawing.Color.Transparent;
            this.btnPrograms.FlatAppearance.BorderSize = 0;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrograms.Image = ((System.Drawing.Image)(resources.GetObject("btnPrograms.Image")));
            this.btnPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograms.Location = new System.Drawing.Point(1, 181);
            this.btnPrograms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(285, 46);
            this.btnPrograms.TabIndex = 4;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 261);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(285, 46);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 108);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(285, 46);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = false;
            // 
            // lapLine
            // 
            this.lapLine.AutoSize = true;
            this.lapLine.Font = new System.Drawing.Font("Bernard MT Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapLine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lapLine.Location = new System.Drawing.Point(1, 72);
            this.lapLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lapLine.Name = "lapLine";
            this.lapLine.Size = new System.Drawing.Size(307, 13);
            this.lapLine.TabIndex = 1;
            this.lapLine.Text = "---------------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Manager";
            // 
            // dtgStudents
            // 
            this.dtgStudents.AllowUserToAddRows = false;
            this.dtgStudents.AllowUserToDeleteRows = false;
            this.dtgStudents.AllowUserToResizeColumns = false;
            this.dtgStudents.AllowUserToResizeRows = false;
            this.dtgStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentImage,
            this.StudentID,
            this.StudentName,
            this.Level,
            this.Program,
            this.DateOfBirth,
            this.ContactID});
            this.dtgStudents.ContextMenuStrip = this.cmStudent;
            this.dtgStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgStudents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgStudents.Location = new System.Drawing.Point(284, 127);
            this.dtgStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgStudents.MultiSelect = false;
            this.dtgStudents.Name = "dtgStudents";
            this.dtgStudents.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgStudents.RowHeadersWidth = 51;
            this.dtgStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgStudents.RowTemplate.Height = 24;
            this.dtgStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStudents.ShowCellErrors = false;
            this.dtgStudents.ShowRowErrors = false;
            this.dtgStudents.Size = new System.Drawing.Size(870, 547);
            this.dtgStudents.TabIndex = 1;
            // 
            // StudentImage
            // 
            this.StudentImage.HeaderText = "picture";
            this.StudentImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.StudentImage.MinimumWidth = 6;
            this.StudentImage.Name = "StudentImage";
            this.StudentImage.ReadOnly = true;
            this.StudentImage.Width = 50;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 83;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 58;
            // 
            // Program
            // 
            this.Program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 6;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.Width = 71;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateOfBirth.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 93;
            // 
            // ContactID
            // 
            this.ContactID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ContactID.HeaderText = "Contact ID";
            this.ContactID.MinimumWidth = 6;
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Width = 83;
            // 
            // cmStudent
            // 
            this.cmStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbmDelete,
            this.tsbmUpdate});
            this.cmStudent.Name = "cmStudent";
            this.cmStudent.Size = new System.Drawing.Size(117, 56);
            // 
            // tsbmDelete
            // 
            this.tsbmDelete.Image = global::Student_Manager.Properties.Resources.delete_20;
            this.tsbmDelete.Name = "tsbmDelete";
            this.tsbmDelete.Size = new System.Drawing.Size(116, 26);
            this.tsbmDelete.Text = "Delete";
            // 
            // tsbmUpdate
            // 
            this.tsbmUpdate.Image = global::Student_Manager.Properties.Resources.update_20;
            this.tsbmUpdate.Name = "tsbmUpdate";
            this.tsbmUpdate.Size = new System.Drawing.Size(116, 26);
            this.tsbmUpdate.Text = "Update";
            this.tsbmUpdate.Click += new System.EventHandler(this.tsbmUpdate_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lapTime);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.txtStaffName);
            this.pnlInfo.Controls.Add(this.txtGreet);
            this.pnlInfo.Location = new System.Drawing.Point(969, 1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(185, 121);
            this.pnlInfo.TabIndex = 2;
            // 
            // lapTime
            // 
            this.lapTime.AutoSize = true;
            this.lapTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lapTime.Location = new System.Drawing.Point(45, 76);
            this.lapTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lapTime.Name = "lapTime";
            this.lapTime.Size = new System.Drawing.Size(42, 19);
            this.lapTime.TabIndex = 7;
            this.lapTime.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.AutoSize = true;
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(4, 29);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(71, 15);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.Text = "Staff Name";
            // 
            // txtGreet
            // 
            this.txtGreet.AutoSize = true;
            this.txtGreet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreet.Location = new System.Drawing.Point(3, 8);
            this.txtGreet.Name = "txtGreet";
            this.txtGreet.Size = new System.Drawing.Size(130, 21);
            this.txtGreet.TabIndex = 3;
            this.txtGreet.Text = "Welcome Back ,";
            // 
            // btnAddStduent
            // 
            this.btnAddStduent.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddStduent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStduent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStduent.Location = new System.Drawing.Point(290, 77);
            this.btnAddStduent.Name = "btnAddStduent";
            this.btnAddStduent.Size = new System.Drawing.Size(175, 45);
            this.btnAddStduent.TabIndex = 3;
            this.btnAddStduent.Text = "Add Studnet";
            this.btnAddStduent.UseVisualStyleBackColor = false;
            this.btnAddStduent.Click += new System.EventHandler(this.btnAddStduent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBarSearch);
            this.panel3.Location = new System.Drawing.Point(471, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 96);
            this.panel3.TabIndex = 4;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Student ID ",
            "Name",
            "Level",
            "Program",
            "Contact ID",
            "Date Of Birth"});
            this.cbSearch.Location = new System.Drawing.Point(199, 39);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 23);
            this.cbSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search for Students";
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarSearch.Location = new System.Drawing.Point(3, 67);
            this.txtBarSearch.MaxLength = 500;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.Size = new System.Drawing.Size(487, 27);
            this.txtBarSearch.TabIndex = 6;
            this.txtBarSearch.WordWrap = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1155, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddStduent);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dtgStudents);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1220, 714);
            this.MinimumSize = new System.Drawing.Size(1154, 714);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainScreen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).EndInit();
            this.cmStudent.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lapLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStaffLog;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label txtStaffName;
        private System.Windows.Forms.Label txtGreet;
        private System.Windows.Forms.Button btnAddStduent;
        private System.Windows.Forms.ContextMenuStrip cmStudent;
        private System.Windows.Forms.ToolStripMenuItem tsbmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsbmUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBarSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lapTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgStudents;
        private System.Windows.Forms.DataGridViewImageColumn StudentImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
    }
}