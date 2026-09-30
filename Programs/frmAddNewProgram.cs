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
    public partial class frmAddNewProgram : Form
    {
        
        public frmAddNewProgram()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //this function will check if the program is valid:
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
        //this function will save the program info and send to the function to send to the database:
        private clsCurrentProgram SaveProgramInfo() 

        {
            clsCurrentProgram NewProgram = new clsCurrentProgram();

            NewProgram.ProgramName = txtProgramName.Text;
            NewProgram.Level = cbLevel.Text;

            return NewProgram;

        }
        //this function will send it to the databse :
        private void AddNewProgram(clsCurrentProgram NewProgram) 
        {
         
            try
            {
              Student_Manager__Business_Logic_Layer.BusinessLogic.AddNewProgram(NewProgram.ProgramName, NewProgram.Level);
            }
            catch 
            {
                throw;
            }
          
        }
       
        private void btnAddProgram_Click(object sender, EventArgs e)
        {
         
            clsCurrentProgram program= new clsCurrentProgram();
            if (IsProgramValid())
            {
                program = SaveProgramInfo();

                try 
                {
                    AddNewProgram(program);
                    MessageBox.Show("Add New Program Done Successfully", "Success", MessageBoxButtons.OK);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
               
            }


            

        }

        
    }
    
}
