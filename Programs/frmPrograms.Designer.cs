namespace Student_Manager.Programs
{
    partial class frmProgram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.ProgramID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.labSearchtxt = new System.Windows.Forms.Label();
            this.txtBarSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            this.dgvPrograms.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrograms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramID,
            this.ProgramName,
            this.Level,
            this.NumOfStudents});
            this.dgvPrograms.Location = new System.Drawing.Point(0, 100);
            this.dgvPrograms.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrograms.MultiSelect = false;
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.RowHeadersWidth = 51;
            this.dgvPrograms.RowTemplate.Height = 24;
            this.dgvPrograms.ShowCellErrors = false;
            this.dgvPrograms.ShowRowErrors = false;
            this.dgvPrograms.Size = new System.Drawing.Size(602, 522);
            this.dgvPrograms.TabIndex = 0;
            // 
            // ProgramID
            // 
            this.ProgramID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProgramID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProgramID.HeaderText = "Program ID";
            this.ProgramID.MinimumWidth = 6;
            this.ProgramID.Name = "ProgramID";
            this.ProgramID.ReadOnly = true;
            this.ProgramID.Width = 79;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProgramName.HeaderText = "Program Name";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            this.ProgramName.Width = 94;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Level.HeaderText = "Program Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 92;
            // 
            // NumOfStudents
            // 
            this.NumOfStudents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumOfStudents.HeaderText = "Number Of Students";
            this.NumOfStudents.MinimumWidth = 6;
            this.NumOfStudents.Name = "NumOfStudents";
            this.NumOfStudents.ReadOnly = true;
            this.NumOfStudents.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumOfStudents.Width = 117;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tomato;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 626);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbSearch);
            this.panel3.Controls.Add(this.labSearchtxt);
            this.panel3.Controls.Add(this.txtBarSearch);
            this.panel3.Location = new System.Drawing.Point(138, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 91);
            this.panel3.TabIndex = 5;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Program ID",
            "Program Name",
            "Level",
            "Number of students"});
            this.cbbSearch.Location = new System.Drawing.Point(112, 25);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(121, 23);
            this.cbbSearch.TabIndex = 6;
            // 
            // labSearchtxt
            // 
            this.labSearchtxt.AutoSize = true;
            this.labSearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearchtxt.Location = new System.Drawing.Point(96, 1);
            this.labSearchtxt.Name = "labSearchtxt";
            this.labSearchtxt.Size = new System.Drawing.Size(164, 21);
            this.labSearchtxt.TabIndex = 7;
            this.labSearchtxt.Text = "Search for Programs";
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarSearch.Location = new System.Drawing.Point(37, 54);
            this.txtBarSearch.MaxLength = 500;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.Size = new System.Drawing.Size(257, 27);
            this.txtBarSearch.TabIndex = 6;
            this.txtBarSearch.WordWrap = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(604, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPrograms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(620, 714);
            this.MinimumSize = new System.Drawing.Size(620, 714);
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.frmProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrograms;
        protected System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfStudents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label labSearchtxt;
        private System.Windows.Forms.TextBox txtBarSearch;
    }
}