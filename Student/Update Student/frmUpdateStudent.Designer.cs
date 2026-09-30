namespace Student_Manager.Update_Student
{
    partial class frmUpdateStudent
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProgram
            // 
            this.cbProgram.DisplayMember = "Name";
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // label1
            // 
            this.label1.Image = global::Student_Manager.Properties.Resources.update_20;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Size = new System.Drawing.Size(398, 55);
            this.label1.Text = "   Update Student";
            // 
            // btnAddStduent
            // 
            this.btnAddStduent.Text = "Update";
            this.btnAddStduent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmUpdateStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(656, 604);
            this.Name = "frmUpdateStudent";
            this.Text = "Update Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}