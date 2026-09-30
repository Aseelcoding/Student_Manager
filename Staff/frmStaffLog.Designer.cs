namespace Student_Manager.Staff
{
    partial class frmStaffLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.labSearchtxt = new System.Windows.Forms.Label();
            this.txtBarSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStaffLog = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSearch);
            this.panel3.Controls.Add(this.labSearchtxt);
            this.panel3.Controls.Add(this.txtBarSearch);
            this.panel3.Location = new System.Drawing.Point(13, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 112);
            this.panel3.TabIndex = 6;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Log ID",
            "Satff ID",
            "Student ID",
            "Operation Type",
            "Time"});
            this.cbSearch.Location = new System.Drawing.Point(254, 36);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(160, 28);
            this.cbSearch.TabIndex = 6;
            // 
            // labSearchtxt
            // 
            this.labSearchtxt.AutoSize = true;
            this.labSearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearchtxt.Location = new System.Drawing.Point(231, 5);
            this.labSearchtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSearchtxt.Name = "labSearchtxt";
            this.labSearchtxt.Size = new System.Drawing.Size(211, 28);
            this.labSearchtxt.TabIndex = 7;
            this.labSearchtxt.Text = "Search for Staff\'s log";
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarSearch.Location = new System.Drawing.Point(154, 71);
            this.txtBarSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarSearch.MaxLength = 500;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.Size = new System.Drawing.Size(341, 32);
            this.txtBarSearch.TabIndex = 6;
            this.txtBarSearch.WordWrap = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tomato;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(5, 760);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvStaffLog
            // 
            this.dgvStaffLog.AllowUserToAddRows = false;
            this.dgvStaffLog.AllowUserToDeleteRows = false;
            this.dgvStaffLog.AllowUserToResizeColumns = false;
            this.dgvStaffLog.AllowUserToResizeRows = false;
            this.dgvStaffLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaffLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.StaffID,
            this.StudentID,
            this.Operation,
            this.Time});
            this.dgvStaffLog.Location = new System.Drawing.Point(6, 125);
            this.dgvStaffLog.Name = "dgvStaffLog";
            this.dgvStaffLog.RowHeadersWidth = 51;
            this.dgvStaffLog.RowTemplate.Height = 24;
            this.dgvStaffLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffLog.ShowCellErrors = false;
            this.dgvStaffLog.ShowRowErrors = false;
            this.dgvStaffLog.Size = new System.Drawing.Size(694, 635);
            this.dgvStaffLog.TabIndex = 10;
            // 
            // LogID
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.NullValue = null;
            this.LogID.DefaultCellStyle = dataGridViewCellStyle1;
            this.LogID.HeaderText = "Log ID";
            this.LogID.MinimumWidth = 6;
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            this.LogID.Width = 125;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation Type";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // frmStaffLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 821);
            this.Controls.Add(this.dgvStaffLog);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(721, 868);
            this.MinimumSize = new System.Drawing.Size(721, 868);
            this.Name = "frmStaffLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffLog";
            this.Load += new System.EventHandler(this.frmStaffLog_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label labSearchtxt;
        private System.Windows.Forms.TextBox txtBarSearch;
        protected System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvStaffLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}