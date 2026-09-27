namespace Student_Manager.Add_Student
{
    partial class frmAddStduent
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
            this.btnAddStduent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lapStudentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fdPersonalPhoto = new System.Windows.Forms.OpenFileDialog();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.pbPersonalPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStduent
            // 
            this.btnAddStduent.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddStduent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStduent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStduent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStduent.Location = new System.Drawing.Point(4, 672);
            this.btnAddStduent.Name = "btnAddStduent";
            this.btnAddStduent.Size = new System.Drawing.Size(142, 51);
            this.btnAddStduent.TabIndex = 1;
            this.btnAddStduent.Text = "Add";
            this.btnAddStduent.UseVisualStyleBackColor = false;
            this.btnAddStduent.Click += new System.EventHandler(this.btnAddStduent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(718, 672);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbProgram);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lapStudentID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 585);
            this.panel1.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(99, 511);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(440, 58);
            this.txtAddress.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact Info : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.mtxPhone);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 106);
            this.panel2.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(283, 44);
            this.txtEmail.MaxLength = 500;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // mtxPhone
            // 
            this.mtxPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxPhone.Location = new System.Drawing.Point(79, 44);
            this.mtxPhone.Mask = "000-000000000";
            this.mtxPhone.Name = "mtxPhone";
            this.mtxPhone.Size = new System.Drawing.Size(132, 30);
            this.mtxPhone.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phone :";
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "yyyy/mm/dd";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(142, 297);
            this.txtDate.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(113, 22);
            this.txtDate.TabIndex = 10;
            this.txtDate.Value = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date Of birth :";
            // 
            // cbProgram
            // 
            this.cbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(108, 228);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(121, 24);
            this.cbProgram.TabIndex = 7;
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Bachelor",
            "Master",
            "Doctoral"});
            this.cbLevel.Location = new System.Drawing.Point(108, 169);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 24);
            this.cbLevel.TabIndex = 6;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Program :";
            // 
            // txtName
            // 
            this.txtName.DetectUrls = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(88, 107);
            this.txtName.MaxLength = 500;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 33);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // lapStudentID
            // 
            this.lapStudentID.AutoSize = true;
            this.lapStudentID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapStudentID.Location = new System.Drawing.Point(119, 34);
            this.lapStudentID.Name = "lapStudentID";
            this.lapStudentID.Size = new System.Drawing.Size(34, 23);
            this.lapStudentID.TabIndex = 1;
            this.lapStudentID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stduent ID : ";
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnChangePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePhoto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.Location = new System.Drawing.Point(647, 309);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(153, 38);
            this.btnChangePhoto.TabIndex = 5;
            this.btnChangePhoto.Text = "Chnage Photo";
            this.btnChangePhoto.UseVisualStyleBackColor = false;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // pbPersonalPhoto
            // 
            this.pbPersonalPhoto.Location = new System.Drawing.Point(612, 82);
            this.pbPersonalPhoto.Name = "pbPersonalPhoto";
            this.pbPersonalPhoto.Size = new System.Drawing.Size(224, 209);
            this.pbPersonalPhoto.TabIndex = 4;
            this.pbPersonalPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Image = global::Student_Manager.Properties.Resources.add_50;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "   Add Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAddStduent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(872, 735);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.pbPersonalPhoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddStduent);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(890, 782);
            this.MinimumSize = new System.Drawing.Size(890, 782);
            this.Name = "frmAddStduent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stduent";
            this.Load += new System.EventHandler(this.frmAddStduent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lapStudentID;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.RichTextBox txtName;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DateTimePicker txtDate;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.ComboBox cbProgram;
        protected System.Windows.Forms.ComboBox cbLevel;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.MaskedTextBox mtxPhone;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.PictureBox pbPersonalPhoto;
        protected System.Windows.Forms.Button btnChangePhoto;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button btnAddStduent;
        protected System.Windows.Forms.OpenFileDialog fdPersonalPhoto;
    }
}