namespace Student_Manager.Programs
{
    partial class frmUpdateProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateProgram = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lapProgramID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Image = global::Student_Manager.Properties.Resources.add_50;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "   Update Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(403, 377);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateProgram
            // 
            this.btnUpdateProgram.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdateProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProgram.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProgram.Location = new System.Drawing.Point(49, 377);
            this.btnUpdateProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateProgram.Name = "btnUpdateProgram";
            this.btnUpdateProgram.Size = new System.Drawing.Size(141, 50);
            this.btnUpdateProgram.TabIndex = 9;
            this.btnUpdateProgram.Text = "Update";
            this.btnUpdateProgram.UseVisualStyleBackColor = false;
            this.btnUpdateProgram.Click += new System.EventHandler(this.btnUpdateProgram_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProgramName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lapProgramID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(52, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 272);
            this.panel1.TabIndex = 8;
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Bachelor",
            "Master",
            "Doctoral"});
            this.cbLevel.Location = new System.Drawing.Point(96, 98);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLevel.MaxLength = 25;
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 24);
            this.cbLevel.TabIndex = 6;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Level :";
            // 
            // txtProgramName
            // 
            this.txtProgramName.DetectUrls = false;
            this.txtProgramName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramName.Location = new System.Drawing.Point(96, 156);
            this.txtProgramName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProgramName.MaxLength = 100;
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(364, 34);
            this.txtProgramName.TabIndex = 3;
            this.txtProgramName.Text = "";
            this.txtProgramName.TextChanged += new System.EventHandler(this.txtProgramName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // lapProgramID
            // 
            this.lapProgramID.AutoSize = true;
            this.lapProgramID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapProgramID.Location = new System.Drawing.Point(144, 34);
            this.lapProgramID.Name = "lapProgramID";
            this.lapProgramID.Size = new System.Drawing.Size(34, 23);
            this.lapProgramID.TabIndex = 1;
            this.lapProgramID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Program ID : ";
            // 
            // frmUpdateProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateProgram);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(609, 480);
            this.MinimumSize = new System.Drawing.Size(609, 480);
            this.Name = "frmUpdateProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Program";
            this.Load += new System.EventHandler(this.frmUpdateProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtProgramName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lapProgramID;
        private System.Windows.Forms.Label label2;
    }
}