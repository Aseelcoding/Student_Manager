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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.ProgramID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPrograms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.labSearchtxt = new System.Windows.Forms.Label();
            this.txtBarSearch = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.cmPrograms.SuspendLayout();
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
            this.dgvPrograms.ContextMenuStrip = this.cmPrograms;
            this.dgvPrograms.Location = new System.Drawing.Point(0, 123);
            this.dgvPrograms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrograms.MultiSelect = false;
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.RowHeadersWidth = 51;
            this.dgvPrograms.RowTemplate.Height = 24;
            this.dgvPrograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrograms.ShowCellErrors = false;
            this.dgvPrograms.ShowRowErrors = false;
            this.dgvPrograms.Size = new System.Drawing.Size(803, 642);
            this.dgvPrograms.TabIndex = 0;
            // 
            // ProgramID
            // 
            this.ProgramID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProgramID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProgramID.HeaderText = "Program ID";
            this.ProgramID.MinimumWidth = 6;
            this.ProgramID.Name = "ProgramID";
            this.ProgramID.ReadOnly = true;
            this.ProgramID.Width = 96;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProgramName.HeaderText = "Program Name";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            this.ProgramName.Width = 118;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Level.HeaderText = "Program Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 114;
            // 
            // NumOfStudents
            // 
            this.NumOfStudents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumOfStudents.HeaderText = "Number Of Students";
            this.NumOfStudents.MinimumWidth = 6;
            this.NumOfStudents.Name = "NumOfStudents";
            this.NumOfStudents.ReadOnly = true;
            this.NumOfStudents.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumOfStudents.Width = 142;
            // 
            // cmPrograms
            // 
            this.cmPrograms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmPrograms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbmUpdate,
            this.tsbmDelete});
            this.cmPrograms.Name = "cmStudent";
            this.cmPrograms.Size = new System.Drawing.Size(132, 56);
            // 
            // tsbmUpdate
            // 
            this.tsbmUpdate.Image = global::Student_Manager.Properties.Resources.update_20;
            this.tsbmUpdate.Name = "tsbmUpdate";
            this.tsbmUpdate.Size = new System.Drawing.Size(131, 26);
            this.tsbmUpdate.Text = "Update";
            this.tsbmUpdate.Click += new System.EventHandler(this.tsbmUpdate_Click);
            // 
            // tsbmDelete
            // 
            this.tsbmDelete.Image = global::Student_Manager.Properties.Resources.delete_20;
            this.tsbmDelete.Name = "tsbmDelete";
            this.tsbmDelete.Size = new System.Drawing.Size(131, 26);
            this.tsbmDelete.Text = "Delete";
            this.tsbmDelete.Click += new System.EventHandler(this.tsbmDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tomato;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 770);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 50);
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
            this.panel3.Location = new System.Drawing.Point(360, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 112);
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
            this.cbbSearch.Location = new System.Drawing.Point(149, 31);
            this.cbbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(160, 28);
            this.cbbSearch.TabIndex = 6;
            // 
            // labSearchtxt
            // 
            this.labSearchtxt.AutoSize = true;
            this.labSearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearchtxt.Location = new System.Drawing.Point(128, 1);
            this.labSearchtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSearchtxt.Name = "labSearchtxt";
            this.labSearchtxt.Size = new System.Drawing.Size(205, 28);
            this.labSearchtxt.TabIndex = 7;
            this.labSearchtxt.Text = "Search for Programs";
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarSearch.Location = new System.Drawing.Point(49, 66);
            this.txtBarSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarSearch.MaxLength = 500;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.Size = new System.Drawing.Size(341, 32);
            this.txtBarSearch.TabIndex = 6;
            this.txtBarSearch.WordWrap = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProgram.Location = new System.Drawing.Point(0, 71);
            this.btnAddProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(352, 55);
            this.btnAddProgram.TabIndex = 7;
            this.btnAddProgram.Text = "Add Program";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(803, 821);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPrograms);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(821, 868);
            this.MinimumSize = new System.Drawing.Size(821, 868);
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.frmProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.cmPrograms.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmPrograms;
        private System.Windows.Forms.ToolStripMenuItem tsbmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsbmUpdate;
        private System.Windows.Forms.Button btnAddProgram;
    }
}