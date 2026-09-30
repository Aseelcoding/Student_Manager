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

        //this function will check if the program is valid or not :
        private bool IsProgramValid()
        {
            bool IsValid = true;
            if (cbLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the level of the program", "Warning", MessageBoxButtons.OK);
                cbLevel.SelectedIndex = 0;
                IsValid = false;

            }
            if (txtProgramName.Text.Length > 100 || txtProgramName.Text.Length < 3)
            {
                MessageBox.Show("Please, the name of the program must be less than or eq to 100 and more than 6 the", "Warning", MessageBoxButtons.OK);
                txtProgramName.Clear();
                IsValid = false;
            }
            return IsValid;
        }
        //this function will save the Program info
        private void SaveProgramInObject() 
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

        //this function will send the object to the database to update it :
        private bool UpdateProgram() 
        {
            bool IsUpdated = false;
            try
            {
                IsUpdated = Student_Manager__Business_Logic_Layer.BusinessLogic.UpdateProgramByID
                (cUpdateProgram.ProgramID, cUpdateProgram.ProgramName, cUpdateProgram.Level);
                }
            catch 
            {
                throw;
            }

            return IsUpdated;
        }
        private void btnUpdateProgram_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;
            if (IsProgramValid())
            {
                SaveProgramInObject();

                try
                {
                    IsUpdated= UpdateProgram();
                    if (IsUpdated)
                    {
                        MessageBox.Show("Update Done successfully to the progrm with ID :" + cUpdateProgram.ProgramID, "success", MessageBoxButtons.OK);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void txtProgramName_TextChanged(object sender, EventArgs e)
        {
            SaveProgramInObject();
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveProgramInObject();
        }
    }
}
