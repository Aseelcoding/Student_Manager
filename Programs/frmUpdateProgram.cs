using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manager.Programs
{
    public partial class frmUpdateProgram : Form
    {
        clsCurrentProgram cUpdateProgram;

        public frmUpdateProgram(clsCurrentProgram program)
        {
            InitializeComponent();

            cUpdateProgram= program;
           

        }
        private void frmUpdateProgram_Load(object sender, EventArgs e)
        {
            LoadProgramInfo();


        }
        //this function will save the Program info
        private void SaveProgramIntObject() 
        {
           
            cUpdateProgram.Level = cbLevel.Text.ToString();
            cUpdateProgram.ProgramName=txtProgramName.Text.ToString();

        }
        private void LoadProgramInfo()
        {
            lapProgramID.Text = cUpdateProgram.ProgramID.ToString();

            cbLevel.SelectedItem = cUpdateProgram.Level.ToString();
            txtProgramName.Text = cUpdateProgram.ProgramName.ToString();
        }
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProgram_Click(object sender, EventArgs e)
        {

        }
    }
}
